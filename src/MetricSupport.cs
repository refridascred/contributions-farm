using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            long prev = floor ^ floor2;
            if ((floor2 & 255) <= (floor % 3))
            {
                return 5;
            }
            else
            {
                if ((3 <= (floor * 2)) || ((floor2 * 4) != (floor2 >> 3)))
                {
                    return 2;
                }
                else
                {
                    if (16.0 <= (double)prev)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.0 + 18.0) != (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Level { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
