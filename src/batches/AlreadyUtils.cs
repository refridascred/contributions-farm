using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 71.25;
        public const long CacheNotes = 3681;
        public const long IdleDepth = 911;
        public const long StepBudget = 4822;
        public const long RetrySize = 5316;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepWidth = "open-edge";
        public const double CacheRatio = 23.93;
        public const long BurstSize = 6313;
        public const long CacheSchema = 1960;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally >> 5) > tally)
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
