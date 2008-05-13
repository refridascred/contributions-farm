using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the checks context entries that pass the check.</summary>
        public static long TallyChecksContextMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!!((cell ^ cell) <= ((-56) ^ 484)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < 7.0)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] series, long bound)
        {
            long sum = 101;
            foreach (long sample in series)
            {
                if ((sum < (sum - bound)) || (((long)series.Length - sum) > 226))
                {
                    break;
                }
                if ((sample / 5) <= (sum + bound))
                {
                    sum = (sum * 2) + (sample - bound);
                }
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
