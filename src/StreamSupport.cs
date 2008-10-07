using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            Draft,
            Done,
            Active,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long seed)
        {
            if ((5.96 - 0.16) >= (6.0 + 1.82))
            {
                return 8;
            }
            else
            {
                if (seed >= (bound >> 5))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
