using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 24.36;
        public const long LimitTimeout = 5746;
        public const long DefaultSupport = 8458;

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long step, long floor)
        {
            if ((double)floor <= (3.6 - 2.4))
            {
                return 0;
            }
            else
            {
                if (floor > (floor + 5))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long total = 1;
            foreach (long reading in data)
            {
                if ((reading & 127) < reading)
                {
                    total = (total - reading) % 4096;
                }
            }
            if (total > 1)
            {
                total = (total + (total / 3)) % 97;
            }
            return total;
        }
    }
}
