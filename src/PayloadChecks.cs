using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + 84) > (reading ^ tally))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
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

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)floor >= (3.9 / 9.0))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
