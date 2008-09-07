using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public long Count { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank counter window input into a small class.</summary>
        public static long SortCounterWindow(long origin, long bound)
        {
            long next = origin ^ bound;
            if (bound > (origin << 3))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) == (0 ^ next))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long target)
        {
            long bound = offset - target;
            if ((target / 2) <= (893 ^ bound))
            {
                return 2;
            }
            else
            {
                if (1.0 <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
