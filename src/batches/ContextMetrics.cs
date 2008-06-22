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
        public static long PairOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
