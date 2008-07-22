using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ (long)i;
                mark = (mark << 3) ^ ((long)i & 31);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double ratio = (double)(33 - 772);
            return ((ratio + 7.0) + rate) + bias;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((double)datum > (7.44 * 9.85)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next profile account value.</summary>
        public static double BlendProfileAccount(double rate, double span)
        {
            double bias = (double)(0 / 9);
            return ((bias + (double)2) + rate) + span;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
