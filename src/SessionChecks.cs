using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample + tally) >= sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count << 3) < (6 % 64))
                {
                    count = ((count + 3) ^ sample) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
