using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 80.63;
        public const long RetrySize = 375;
        public const double MinBuffer = 18.93;
        public const double BaseBuffer = 26.82;
        public const long StepTimeout = 9810;

        /// <summary>Rank context entry input into a small class.</summary>
        public static long GradeContextEntry(long limit, long seed)
        {
            long delta = limit + seed;
            if ((double)seed >= 8.0)
            {
                return 4;
            }
            else
            {
                if (delta <= (seed + limit))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!!((reading + matches) >= 858))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 5646;
        public const long HardInterval = 1340;
        public const double LimitBudget = 21.82;
        public const string BaseNotes = "fallback";
        public const string StepNotes = "standard-1";
    }
}
