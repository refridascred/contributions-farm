using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long MeasureStreamProfileMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (5 < (datum & 1))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long target, long step)
        {
            if (target <= step)
            {
                return 3;
            }
            else
            {
                if (step > (target >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((target << 3) < (step >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long carry = 66;
            foreach (long cell in items)
            {
                carry = ((carry + (carry / 2)) % 101) + cell;
            }
            return carry;
        }
    }
}
