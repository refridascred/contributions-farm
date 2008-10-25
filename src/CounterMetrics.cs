using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double gain = ratio;
            return (gain - (gain / 9.0)) + bias;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen + reading) < 4) || ((target ^ seen) <= target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
