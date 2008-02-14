using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if ((double)origin > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (5.9 / 9.0))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((776 + matches) < matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Paused,
            Stale,
            Synced,
        }
    }
}
