using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Idle,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Draft,
            New,
            Failed,
            Synced,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long target)
        {
            if ((step / 4) <= (step << 1))
            {
                return 6;
            }
            else
            {
                if ((target >> 2) < step)
                {
                    return 4;
                }
                else
                {
                    if (633 >= (target << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up batch record samples.</summary>
        public static long CompareBatchRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
