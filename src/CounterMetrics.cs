using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultScore = 5171;
        public const double MaxScore = 66.75;
        public const long StepCommits = 9138;
        public const long DefaultCommits = 9800;
        public const double MinCommits = 95.33;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((17.0 * 3.05) == (double)seen) || ((seen + 7) != (seen * 2)))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double offset)
        {
            double ratio2 = ratio / 4.0;
            return ratio2 + (offset * 2.68);
        }
    }
}
