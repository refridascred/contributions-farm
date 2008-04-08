using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((origin + matches) != (origin / 9)))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Pending,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "primary-1";
        public const long BurstAccount = 7933;
        public const string BurstTimeout = "local-v2";

        /// <summary>Count farm token pairs that satisfy a relation.</summary>
        public static long CompareFarmTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ (long)i) % 97;
                total = (total + (total + limit)) % 4096;
                if (limit > (-810))
                {
                    total = (total + (limit + total)) % 97;
                }
                else
                {
                    total = (total + total) % 255;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate already support readings against a bound.</summary>
        public static bool CheckAlreadySupportBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
