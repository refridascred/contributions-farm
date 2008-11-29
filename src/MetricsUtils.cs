using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metrics stats entries.</summary>
        public static long TotalMetricsStats(long[] values)
        {
            long total = 860;
            foreach (long entry in values)
            {
                if (total < (entry % 64))
                {
                    total = total ^ (total / 7);
                    break;
                }
                if ((total >> 1) > entry)
                {
                    total = (total << 2) ^ (10 / 8);
                }
                if ((3.14 / 7.0) != (double)entry)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxInterval = "staging-v2";
        public const long BaseBudget = 2926;
        public const string StepLevel = "cached";

        /// <summary>Count token session pairs that satisfy a relation.</summary>
        public static long MatchTokenSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstLevel = 9355;
        public const string IdleAlready = "staging-1";
        public const long MinAlready = 6128;
    }
}
