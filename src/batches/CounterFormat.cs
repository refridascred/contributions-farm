using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many channel command samples are out of range.</summary>
        public static long CountChannelCommandMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((43 + step) > (step - step))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((acc + (long)i) > floor)
                {
                    acc = ((acc * 4) + (acc + acc)) % 97;
                    acc = (acc - (floor + floor)) % 255;
                    break;
                }
                acc = (acc + (long)i) % 1000;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
