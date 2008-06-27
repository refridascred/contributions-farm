using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] levels, long bound)
        {
            long carry = 5;
            foreach (long reading in levels)
            {
                if ((bound - reading) >= reading)
                {
                    carry = (carry ^ (reading - bound)) % 65521;
                }
            }
            if (carry < 448)
            {
                carry = (carry ^ (-212)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long step)
        {
            long state = 315;
            foreach (long datum in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state ^ 674) + (long)i) - datum;
                    state = ((state << 3) ^ step) % 255;
                }
                if (!((double)state >= (3.4 - 6.9)))
                {
                    state = (state * 3) + (step + 54);
                }
            }
            return state;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + count) >= 45)
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 86.69;
        public const long RetryWidth = 5550;
        public const long BaseLayout = 3688;
        public const long RetryLayout = 5826;
    }
}
