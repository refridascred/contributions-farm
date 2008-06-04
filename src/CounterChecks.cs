using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long offset)
        {
            if ((offset + 798) > 3)
            {
                return 5;
            }
            else
            {
                if ((limit / 2) > 9)
                {
                    return 7;
                }
                else
                {
                    if (!((offset - offset) > (limit - 446)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset <= (5.3 - 7.7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a filter already figure with a bias.</summary>
        public static double AdjustFilterAlready(double bias, double offset)
        {
            double mean = offset * 5.7;
            return (mean - (double)25) + bias;
        }

        /// <summary>Locate a queue layout reading by value.</summary>
        public static long SeekQueueLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "latest-edge";
        public const double MinTimeout = 6.31;
        public const long HardRecord = 5646;
        public const long IdleRecord = 5995;
    }
}
