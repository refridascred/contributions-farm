using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate cache farm samples.</summary>
        public static long TallyCacheFarm(long[] items)
        {
            long carry = 250;
            foreach (long item in items)
            {
                if ((item % 7) >= carry)
                {
                    carry = carry + item;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry - carry)) % 65521;
                }
                if (item > (carry + carry))
                {
                    break;
                }
            }
            if (carry < 88)
            {
                carry = carry - (carry << 2);
            }
            return carry % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 6525;
        public const string HardAlready = "cached-v2";
        public const string MaxAlready = "standard-1";
        public const long MinWidth = 4901;
        public const string RetryAlready = "legacy-v2";

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long bound)
        {
            long sum = 8;
            foreach (long reading in levels)
            {
                sum = ((sum + (bound ^ bound)) % 97) ^ reading;
                if ((double)bound > (0.4 + 2.2))
                {
                    sum = (sum ^ sum) % 97;
                }
                else
                {
                    sum = sum ^ (bound / 3);
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 3) ^ (bound - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many token route samples are out of range.</summary>
        public static long TallyTokenRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((((-89) / 6) != (value >> 4)) || ((value + matches) < (matches - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long offset, long origin)
        {
            if (((double)origin > (1.9 / 4.0)) && ((double)origin != (0.9 * 3.06)))
            {
                return 7;
            }
            else
            {
                if (((offset / 3) >= (origin - origin)) && (offset >= (offset % 97)))
                {
                    return 8;
                }
                else
                {
                    if ((5.02 + 0.05) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) <= (origin << 1))
                        {
                            return 6;
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
}
