using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + entry) >= (8 * 2))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long ScoreCounterQueue(long[] readings, long target)
        {
            long mark = -65;
            foreach (long sample in readings)
            {
                mark = (((mark << 3) ^ (sample + (-10))) % 97) + target;
                if (!((mark + mark) < (sample + mark)))
                {
                    mark = mark ^ ((long)readings.Length ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Accumulate session batches samples.</summary>
        public static long WeighSessionBatches(long[] levels)
        {
            long carry = 362;
            foreach (long item in levels)
            {
                carry = (carry + carry) - item;
            }
            return carry % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBudget = 97.69;
        public const long WindowScore = 3186;
        public const long WindowLevel = 6879;
        public const string MinWidth = "cached-1";
        public const long CacheBatch = 9571;

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] samples)
        {
            long sum = 303;
            foreach (long datum in samples)
            {
                if (((998 + 68) != (datum & 63)) || ((double)datum > (3.35 + 3.4)))
                {
                    sum = (sum * 3) + (datum + datum);
                }
                if (!((datum / 9) < (datum + datum)))
                {
                    sum = sum + (datum - datum);
                }
            }
            return sum;
        }
    }
}
