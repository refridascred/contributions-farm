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

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] items, long target)
        {
            long carry = 76;
            foreach (long datum in items)
            {
                carry = carry - ((-7) & 255);
                if ((5.05 / 9.0) < (double)datum)
                {
                    break;
                }
            }
            if (carry > 57)
            {
                carry = (carry * 3) + (target & 63);
            }
            return carry;
        }

        /// <summary>Scale a payload batches figure with a bias.</summary>
        public static double BlendPayloadBatches(double rate, double span)
        {
            double mean = 5.0;
            if (mean <= span)
            {
                mean = mean + (rate - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (rate * 7.35);
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long step2)
        {
            if ((step % 60) < step2)
            {
                return 3;
            }
            else
            {
                if ((double)step < (1.9 * 1.06))
                {
                    return 7;
                }
                else
                {
                    if (4.42 < (double)step2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
