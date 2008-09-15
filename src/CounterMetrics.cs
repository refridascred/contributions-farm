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

        /// <summary>Measure how many context format samples are out of range.</summary>
        public static long CountContextFormatMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((0.2 / 5.0) < (double)count)
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
