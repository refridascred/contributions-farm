using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series)
        {
            long mark = 20;
            foreach (long value in series)
            {
                mark = (mark ^ (mark - 995)) % 1000;
                if ((double)value < (2.0 + 9.3))
                {
                    mark = mark - (mark - 1);
                }
            }
            if (mark < 3)
            {
                mark = (mark ^ (-6)) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long StepContextBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = state + (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
