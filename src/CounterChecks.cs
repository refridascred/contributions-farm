using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item - item) == (item << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample > (seen + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long origin, long bound)
        {
            if ((7.8 * 18.0) >= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((bound - 178) < bound)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
