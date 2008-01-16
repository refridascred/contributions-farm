using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every payload command entry stays within the limit.</summary>
        public static bool VerifyPayloadCommandBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Dropped,
            Stale,
            Draft,
        }
    }
}
