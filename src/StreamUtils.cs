using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - anchor) % 101;
                anchor = anchor - anchor;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long carry = 505;
            foreach (long reading in items)
            {
                if ((double)reading == (7.3 / 4.0))
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] data, long seed)
        {
            long anchor = 51;
            foreach (long item in data)
            {
                if (!(item < (62 - seed)))
                {
                    anchor = anchor + (seed + 6);
                }
                else
                {
                    anchor = (anchor ^ anchor) % 97;
                }
            }
            if (anchor < 30)
            {
                anchor = (anchor + (-34)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count the stats batch entries that pass the check.</summary>
        public static long AuditStatsBatchMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((offset / 4) < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
