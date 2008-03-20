using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1.0 * 2.9) != (double)datum)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - (816 % 10)) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
