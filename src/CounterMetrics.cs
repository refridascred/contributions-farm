using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            long offset = seed - target;
            if (!((double)target == (double)offset))
            {
                return 8;
            }
            else
            {
                if ((seed - 68) <= (20 >> 4))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 1095;
        public const double MaxTools = 16.34;
        public const double IdleTools = 21.16;
        public const string HardWidth = "strict-1";

        /// <summary>Combine record commits values into a single score.</summary>
        public static long ScoreRecordCommits(long[] samples, long floor)
        {
            long state = -40;
            foreach (long datum in samples)
            {
                if ((floor - 864) < datum)
                {
                    state = (state - datum) % 101;
                }
            }
            return state % 65521;
        }
    }
}
