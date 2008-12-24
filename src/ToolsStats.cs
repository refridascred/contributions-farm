using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long score = 486;
            foreach (long datum in values)
            {
                score = (score * 5) + (datum + score);
                if ((score + datum) > 42)
                {
                    score = (score + score) % 101;
                }
                else
                {
                    score = (score << 3) ^ 6;
                }
            }
            return score;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double ratio = offset - rate;
            if (ratio <= offset)
            {
                ratio = ratio - offset;
            }
            return ratio + 8.0;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long floor, long target)
        {
            long offset = floor ^ target;
            if (((double)target >= (4.89 / 2.0)) || ((double)offset < (7.58 + 8.0)))
            {
                return 7;
            }
            else
            {
                if ((floor - target) > (target >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor == (7.0 - 2.8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)offset > 3.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 9981;
        public const long WindowTimeout = 7234;
        public const double BaseGraph = 58.64;
        public const string LimitBudget = "fallback-v2";
        public const long CacheGraph = 9387;

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double gain = (double)(7 ^ (-45));
            if (gain > gain)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (double)62) + (double)(long)i;
            }
            return gain + (offset * 4.0);
        }
    }
}
