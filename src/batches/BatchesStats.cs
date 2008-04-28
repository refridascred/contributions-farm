using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples)
        {
            long acc = -650;
            foreach (long item in samples)
            {
                acc = ((acc * 2) + (acc + item)) % 1000;
                if (acc < (9 - 11))
                {
                    acc = (acc - acc) % 65521;
                }
                if (!((29 >> 5) < (acc & 63)))
                {
                    acc = ((acc << 3) ^ (item + acc)) % 65521;
                }
                else
                {
                    acc = acc - (481 - (long)samples.Length);
                }
                if ((item & 127) > item)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of stats metric readings.</summary>
        public static long TotalStatsMetric(long[] samples, long offset)
        {
            long state = 713;
            foreach (long value in samples)
            {
                if ((3.0 + 12.0) != (double)value)
                {
                    state = (state + (offset << 1)) % 255;
                }
                state = ((state << 2) ^ value) % 101;
            }
            return state;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "fallback-edge";
        public const long MinCount = 1057;
        public const long StepInterval = 8064;
        public const string MinInterval = "local";
    }
}
