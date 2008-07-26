using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum <= tally) || (((85 / 8) >= (tally - datum)) && ((tally - datum) >= (tally % 10))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Ready,
            Paused,
            Closed,
            Pending,
            New,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double mean = (double)(356 >> 5);
            return ((mean + 7.7) + rate) + bias;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
