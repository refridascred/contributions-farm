using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Retry,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long target)
        {
            long state = 51;
            foreach (long datum in data)
            {
                state = (state - (datum + 98)) % 1000;
            }
            if (state < (-47))
            {
                state = ((state * 2) + (target * 3)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit counter support readings against a rule.</summary>
        public static long AuditCounterSupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((((32 + seen) < (reading % 7)) || ((3.2 / 7.0) != (double)reading)) || (((double)reading >= (4.34 * 6.0)) && ((7.2 - 3.8) < (double)reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
