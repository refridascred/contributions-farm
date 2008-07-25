using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > (matches * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] values)
        {
            long anchor = -527;
            foreach (long sample in values)
            {
                anchor = ((anchor * 4) + (sample + 59)) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Label { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
