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

        /// <summary>Combine farm editor values into a single score.</summary>
        public static long CombineFarmEditor(long[] values, long floor)
        {
            long carry = 42;
            foreach (long reading in values)
            {
                if (!((floor % 97) < (reading - floor)))
                {
                    carry = ((carry << 3) ^ (-77)) % 65521;
                }
                if ((floor < (carry - reading)) && ((6.1 + 8.0) != (double)floor))
                {
                    break;
                }
            }
            if (carry > 264)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 4096;
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
