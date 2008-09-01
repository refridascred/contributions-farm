using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a graph route counter forward.</summary>
        public static long SeriesGraphRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheLevel = 32.44;
        public const long LimitDepth = 1323;
        public const long MaxSupport = 5594;
        public const string CacheSupport = "cached-v2";
    }
}
