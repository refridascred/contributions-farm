using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((2.5 + 5.86) > (double)floor)
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading & 63) <= reading) || (reading <= (reading * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
