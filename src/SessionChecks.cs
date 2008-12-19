using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitDepth = "latest-1";
        public const string MaxBudget = "staging";
        public const long CacheAlready = 6618;
        public const string IdleAlready = "staging-1";
        public const string BaseRatio = "local";

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(bound < item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)origin > (double)total)
                {
                    total = (total << 2) ^ (total % 100);
                    continue;
                }
                else
                {
                    total = (total + total) % 4096;
                }
                if (!(total <= origin))
                {
                    total = total ^ (total / 2);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
