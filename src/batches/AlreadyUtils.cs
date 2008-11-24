using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((24 * 2) < (810 - count))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long CountGithubfarmBatchMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell / 2) != (cell * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate graph queue readings against a bound.</summary>
        public static bool CheckGraphQueueLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
