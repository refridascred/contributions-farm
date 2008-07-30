using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long bound, long target)
        {
            if ((double)target > (17.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((bound & 15) != (5 ^ target))
                {
                    return 1;
                }
                else
                {
                    if ((bound * 4) > (bound + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((-86) <= (bound & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((21 & 1) < (matches & 255)))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Pending,
            Locked,
            Done,
            Stale,
        }
    }
}
