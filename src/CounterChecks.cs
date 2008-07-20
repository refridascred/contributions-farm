using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length >= (double)sample)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series, long bound)
        {
            long state = 148;
            foreach (long item in series)
            {
                state = ((state - (item + state)) % 255) + bound;
            }
            return state;
        }
    }
}
