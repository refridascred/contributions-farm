using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record support counter forward.</summary>
        public static long StepRecordSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)result > (1.0 - 3.0))
                {
                    result = (result * 4) + (step + step);
                }
                if ((step << 3) >= (long)i)
                {
                    result = result - (result + step);
                    result = result - (result ^ step);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Closed,
            Queued,
            Draft,
            Ready,
        }
    }
}
