using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 73.8;
        public const long MaxFactor = 7750;
        public const long CacheContributi = 3282;
        public const long SoftLevel = 9443;

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultDepth = "strict-v2";
        public const long BurstCounter = 7088;
        public const string StepLevel = "stable-edge";
        public const string SoftCounter = "stable-edge";

        /// <summary>Match up order notes samples.</summary>
        public static long OverlapOrderNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)seed <= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
