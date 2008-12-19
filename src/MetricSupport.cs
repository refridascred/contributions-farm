using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate batches layout samples.</summary>
        public static long CombineBatchesLayout(long[] series, long origin)
        {
            long state = 1;
            foreach (long cell in series)
            {
                if ((cell / 3) < ((long)series.Length ^ origin))
                {
                    state = (state ^ (cell + origin)) % 255;
                }
            }
            if (state > (-37))
            {
                state = (state - (96 + state)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long limit)
        {
            long acc = 7;
            foreach (long reading in readings)
            {
                acc = (((acc << 3) ^ (acc / 5)) % 97) - limit;
                acc = (acc + (35 ^ 7)) % 65521;
                acc = ((acc << 2) ^ (11 + reading)) % 101;
            }
            return acc % 97;
        }
    }
}
