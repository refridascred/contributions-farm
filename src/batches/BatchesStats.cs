using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell % 64) <= (40 % 10))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Validate githubfarm layout readings against a bound.</summary>
        public static bool CheckGithubfarmLayoutRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)bound < 4.03))
                {
                    total = total + ((long)i & 127);
                }
                else
                {
                    total = (total + (bound & 7)) % 65521;
                    total = total - ((long)i << 3);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
