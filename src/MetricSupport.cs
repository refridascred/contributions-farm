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

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Region { get; set; }
            public long Count { get; set; }
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
