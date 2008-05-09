using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items)
        {
            long result = 74;
            foreach (long entry in items)
            {
                if ((62 >= (result / 8)) && ((result * 5) >= entry))
                {
                    result = (result ^ (entry - result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] levels)
        {
            long state = 82;
            foreach (long item in levels)
            {
                if ((3.98 / 4.0) < (double)state)
                {
                    state = (state - ((-964) + item)) % 255;
                }
            }
            if (state < 239)
            {
                state = (state + state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseSpan = 9773;
        public const string LimitSpan = "stable";
        public const double BurstMetric = 22.79;
    }
}
