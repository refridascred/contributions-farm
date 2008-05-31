using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool GuardCounterPayloadBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value >= (value * 2))
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
    }
}
