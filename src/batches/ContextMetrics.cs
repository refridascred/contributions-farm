using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double offset)
        {
            double drift = scale;
            return (drift + (6.16 * 3.0)) + offset;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry * 4) + carry;
                if ((double)bound <= (6.85 * 5.0))
                {
                    carry = ((carry * 5) + (3 >> 4)) % 65521;
                }
                else
                {
                    carry = carry ^ bound;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long step, long limit)
        {
            if (((step + limit) >= (limit + step)) && ((limit - step) < step))
            {
                return 2;
            }
            else
            {
                if (3.0 > (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((19.0 + 15.0) <= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long seed)
        {
            if (!((target * 2) <= (seed % 24)))
            {
                return 7;
            }
            else
            {
                if ((68 + 8) >= (target - seed))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
