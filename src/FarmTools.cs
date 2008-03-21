using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format session samples are out of range.</summary>
        public static long AuditFormatSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits <= (7.0 * 6.97))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Dropped,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
