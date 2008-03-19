using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long origin)
        {
            long edge = offset - origin;
            if (edge > (offset ^ 620))
            {
                return 7;
            }
            else
            {
                if ((double)origin < 4.39)
                {
                    return 4;
                }
                else
                {
                    if ((41 - edge) > (offset << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCount = 1904;
        public const double DefaultCommits = 13.58;
        public const long RetryCommits = 4198;
        public const long SoftBudget = 2633;
        public const long BaseCommits = 2727;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Level { get; set; }
            public bool Offset { get; set; }
        }
    }
}
