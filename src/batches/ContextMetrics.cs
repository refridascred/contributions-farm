using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 1987;
        public const double StepRatio = 4.88;
        public const string SoftCount = "staging-1";
        public const double LimitMetrics = 64.86;

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long anchor = 439;
            foreach (long sample in levels)
            {
                if (!((anchor ^ anchor) > (anchor + sample)))
                {
                    anchor = anchor ^ (anchor + sample);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((seed - tally) > (6 * 4)) && !((521 << 2) > (tally + tally)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
