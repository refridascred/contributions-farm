using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] items, long seed)
        {
            long acc = 208;
            foreach (long item in items)
            {
                acc = (acc - seed) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Retry,
            New,
            Failed,
            Draft,
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double ratio = (gain - span) * 3.46;
            return ratio - 3.16;
        }
    }
}
