using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((double)tally <= (double)entry) && (((entry - tally) < 553) || ((entry / 7) == (tally >> 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Ratio { get; set; } = "";
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((double)count >= 1.38))
                {
                    count = ((count + 1) + sample) + target;
                }
            }
            return count;
        }
    }
}
