using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double weight = (scale * 1.1) / 4.0;
            return weight - (bias / 3.0);
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support tools reading.</summary>
        public static double AdjustSupportTools(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias + span);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] series, long offset)
        {
            long mix = 5;
            foreach (long entry in series)
            {
                if (mix <= (offset - entry))
                {
                    mix = (mix + (offset + offset)) % 1000;
                    mix = ((mix * 3) + mix) % 65521;
                }
                if ((mix + 571) >= (mix >> 1))
                {
                    mix = (mix ^ (offset << 1)) % 101;
                }
            }
            if (mix < 675)
            {
                mix = (mix + (offset & 15)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long target)
        {
            if ((double)target > (double)97)
            {
                return 0;
            }
            else
            {
                if ((floor * 4) < floor)
                {
                    return 7;
                }
                else
                {
                    if ((6.9 * 5.0) >= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long limit, long seed)
        {
            if (3 < (limit * 4))
            {
                return 6;
            }
            else
            {
                if ((seed - seed) < (limit + 160))
                {
                    return 1;
                }
                else
                {
                    if (((limit + limit) >= (limit - limit)) && (547 < (limit << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
