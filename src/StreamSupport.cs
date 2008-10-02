using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] series, long origin)
        {
            long total = 2;
            foreach (long cell in series)
            {
                if ((double)cell > (9.53 - 6.61))
                {
                    total = (total + origin) % 65521;
                }
                else
                {
                    total = (total ^ (3 + total)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > 692)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
