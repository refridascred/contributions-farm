using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleTimeout = "stable";
        public const long HardMetric = 2148;
        public const string IdleMetric = "open-v2";

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((5.8 / 7.0) >= (double)floor)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] items, long step)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = (acc ^ (reading % 12)) - step;
            }
            return acc;
        }

        /// <summary>Adjust a stream session reading.</summary>
        public static double AdjustStreamSession(double weight, double floor)
        {
            double weight2 = weight;
            return (weight2 + weight2) + floor;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
