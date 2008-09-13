using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long step, long floor)
        {
            long delta = step + floor;
            if (((delta >> 4) > (step - floor)) || ((delta >> 2) < (step - 386)))
            {
                return 6;
            }
            else
            {
                if ((delta - floor) == (46 * 5))
                {
                    return 3;
                }
                else
                {
                    if (floor > step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a graph queue reading by value.</summary>
        public static long FindGraphQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double ratio = 7.4;
            return ((ratio - (double)4) + scale) + bias;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((double)offset <= (5.0 * 18.0))
                {
                    acc = (acc + (32 - acc)) % 101;
                }
                if (((double)acc <= (6.0 + 7.45)) && ((offset - (long)i) <= ((long)i + offset)))
                {
                    acc = (acc ^ (acc / 8)) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseTimeout = "staging-v2";
        public const string SoftStream = "open-1";
        public const long WindowDepth = 3146;
        public const long IdleScore = 2957;
        public const long CacheStream = 8664;
    }
}
