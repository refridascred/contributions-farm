using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate filter queue samples.</summary>
        public static long WeighFilterQueue(long[] levels)
        {
            long anchor = 152;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 5) + (5 + 6)) % 4096;
                if (66 >= (entry % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long step, long offset)
        {
            long lane = step + offset;
            if ((lane / 8) != (offset >> 4))
            {
                return 7;
            }
            else
            {
                if (!(8.28 > (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 3) <= (lane & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long origin, long seed)
        {
            if ((origin > (origin + origin)) || ((origin << 1) > (-54)))
            {
                return 1;
            }
            else
            {
                if ((double)origin > 8.1)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double load = span;
            if (load > ratio)
            {
                load = load - 1.5;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)17) + (double)(long)i;
            }
            return load - 8.27;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSize = "standard-edge";
        public const double MaxBudget = 55.0;
        public const string HardGithubfarm = "latest-1";
        public const double DefaultGithubfarm = 11.66;
        public const long MaxDepth = 6138;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
