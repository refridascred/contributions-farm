using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long offset)
        {
            if ((double)bound >= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every stats context entry stays within the limit.</summary>
        public static bool VerifyStatsContextBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (965 % 60)) % 65521;
                state = (state - state) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
