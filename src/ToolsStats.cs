using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleScore = 5.05;
        public const long WindowCache = 922;
        public const string SoftCache = "alpha";

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] series, long step)
        {
            long total = 9;
            foreach (long datum in series)
            {
                if (!(total > (step & 255)))
                {
                    total = (total + total) % 97;
                }
                if (((datum + step) == (step - step)) || ((4.9 + 2.93) != (double)total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double bias)
        {
            double weight = (double)((-137) - 7);
            if (weight > (weight / 4.0))
            {
                weight = (weight - (double)50) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 19.0) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long limit)
        {
            long lane = origin - limit;
            if (((origin >> 5) > (3 + 504)) && (25 >= (lane << 1)))
            {
                return 8;
            }
            else
            {
                if ((limit % 7) == (417 + (-958)))
                {
                    return 1;
                }
                else
                {
                    if ((lane + lane) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit > (32 % 16)) || (limit > (origin / 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
