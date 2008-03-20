using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
            public string Limit { get; set; } = "";
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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 12; i++)
            {
                carry = carry + (target % 3);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
