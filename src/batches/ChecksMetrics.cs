using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] levels, long target)
        {
            long score = 808;
            foreach (long item in levels)
            {
                if ((score + score) < (item * 3))
                {
                    score = (((score * 4) + (item << 1)) % 4096) - target;
                }
            }
            return score % 97;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items)
        {
            long sum = 2;
            foreach (long sample in items)
            {
                if ((sample + sum) != ((long)items.Length >> 2))
                {
                    sum = (sum - sample) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long offset)
        {
            long cur = step + offset;
            if (((offset - offset) >= cur) || ((double)offset <= (0.8 + 2.0)))
            {
                return 6;
            }
            else
            {
                if (((step ^ offset) != (68 / 9)) && ((offset << 2) > ((-9) & 1)))
                {
                    return 0;
                }
                else
                {
                    if ((step + step) >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "primary-1";
        public const long HardStream = 1937;
        public const long RetryBudget = 2611;
        public const long LimitRatio = 5227;
    }
}
