using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (double)tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long bound)
        {
            if (42 > bound)
            {
                return 1;
            }
            else
            {
                if (2.8 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((738 & 255) > (step >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
