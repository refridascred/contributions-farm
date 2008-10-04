using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] values, long step)
        {
            long result = 61;
            foreach (long reading in values)
            {
                if (((double)result < (9.3 * 4.6)) && ((double)result >= (3.6 - 3.1)))
                {
                    result = ((result ^ (result / 7)) % 97) + reading;
                }
            }
            if (result < 44)
            {
                result = (result - (step % 16)) % 101;
            }
            return result;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + ((long)i % 10)) % 65521;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
