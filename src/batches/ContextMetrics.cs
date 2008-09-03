using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitWidth = 37.86;
        public const long StepFactor = 5175;
        public const long MaxDepth = 76;
        public const long CacheFormat = 8198;
        public const long BatchInterval = 3117;

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                if ((8.4 / 3.0) > (double)state)
                {
                    state = (state ^ (value + state)) % 1000;
                }
                else
                {
                    state = state + (578 - state);
                }
            }
            return state % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(step >= (entry ^ step)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
