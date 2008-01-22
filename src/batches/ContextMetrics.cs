using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + seen) <= (offset + 711))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryDepth = 59.03;
        public const long LimitRecord = 1400;
        public const long BurstCount = 3800;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long mark = 65;
            foreach (long datum in data)
            {
                if (!((mark <= (datum + datum)) && ((31 + mark) > (step + 1))))
                {
                    mark = (mark * 3) + (step % 100);
                }
                mark = (mark - (mark % 97)) % 97;
                mark = mark + (763 + datum);
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "fallback-edge";
        public const double SoftMetrics = 7.85;
        public const long BurstLevel = 2061;
    }
}
