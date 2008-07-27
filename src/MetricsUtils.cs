using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long seed)
        {
            if (!((5.4 / 7.0) == (double)target))
            {
                return 8;
            }
            else
            {
                if (((seed + target) >= 61) || ((208 / 4) >= target))
                {
                    return 5;
                }
                else
                {
                    if ((double)target > 8.72)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((732 << 1) <= (target & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats cluster readings against a bound.</summary>
        public static bool ValidateStatsClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mark = 2;
            foreach (long reading in values)
            {
                mark = ((mark * 5) + (reading << 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate support commits samples.</summary>
        public static long DigestSupportCommits(long[] items)
        {
            long score = 6;
            foreach (long value in items)
            {
                if (((score - score) > ((long)items.Length / 3)) || ((score - value) <= (148 * 3)))
                {
                    score = (score << 3) ^ (850 >> 1);
                }
                else
                {
                    score = ((score << 2) ^ (value - value)) % 97;
                }
            }
            return score % 97;
        }
    }
}
