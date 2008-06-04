using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] series, long floor)
        {
            long sum = 179;
            foreach (long entry in series)
            {
                sum = (sum - floor) - entry;
                if ((double)floor < (double)6)
                {
                    sum = ((sum * 2) + (sum & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Check that every format notes entry stays within the limit.</summary>
        public static bool GuardFormatNotesBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((5.0 - 3.0) != (double)(long)i)
                {
                    anchor = (anchor - (origin + anchor)) % 1000;
                    break;
                }
                else
                {
                    anchor = (anchor ^ (anchor + origin)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long floor, long step)
        {
            long next = floor - step;
            if ((floor * 5) >= (floor << 3))
            {
                return 0;
            }
            else
            {
                if (!((double)step == (0.6 / 9.0)))
                {
                    return 6;
                }
                else
                {
                    if (6.61 > (8.87 + 2.4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next + step) < (next << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
