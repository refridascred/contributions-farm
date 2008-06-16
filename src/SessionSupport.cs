using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long seed, long floor)
        {
            long next = seed + floor;
            if ((next % 2) < (13 ^ floor))
            {
                return 3;
            }
            else
            {
                if (((double)next >= 4.66) && ((next * 5) < ((-414) - floor)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
