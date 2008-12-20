using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long IteratePayloadEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((9.72 / 9.0) != (double)origin)
                {
                    sum = (sum - (origin ^ sum)) % 1000;
                }
                if (((long)i << 2) > sum)
                {
                    sum = (sum * 2) + (sum + sum);
                    sum = (sum ^ (sum % 7)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long target, long origin)
        {
            if ((origin + origin) >= target)
            {
                return 1;
            }
            else
            {
                if ((origin << 2) <= (target >> 1))
                {
                    return 2;
                }
                else
                {
                    if (origin > (origin + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin <= 3.68)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long target)
        {
            long state = 425;
            foreach (long datum in series)
            {
                state = ((state - (datum - 5)) % 4096) - target;
                if ((735 + state) != (datum - state))
                {
                    state = state + (state - 84);
                }
            }
            return state;
        }
    }
}
