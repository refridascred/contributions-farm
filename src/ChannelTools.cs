using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the order route entries that pass the check.</summary>
        public static long TallyOrderRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!((matches + matches) <= matches) && ((15.0 * 5.6) > (double)matches))
                {
                    matches = (matches + 2) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] values, long floor)
        {
            long total = 97;
            foreach (long entry in values)
            {
                total = (total << 2) ^ ((-7) + entry);
            }
            if (total < (-889))
            {
                total = (total ^ (floor % 10)) % 101;
            }
            return total;
        }
    }
}
