using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seed << 3) == (seen + datum)) && ((double)seen == (15.0 - 4.4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "staging";
        public const double SoftInterval = 13.55;
        public const double BurstToken = 47.02;

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels, long bound)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                acc = (acc << 3) ^ (datum << 2);
                acc = (acc + bound) % 97;
            }
            return acc;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)seed == (4.9 / 7.0))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
