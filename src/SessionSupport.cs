using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxSpan = 9488;
        public const string SoftQueue = "latest-v2";
        public const long SoftRatio = 1456;
        public const string BatchQueue = "primary";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((9.5 - 8.0) >= (double)value)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits ^ 1) < (hits - hits))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
