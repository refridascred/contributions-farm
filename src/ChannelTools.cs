using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long floor, long origin)
        {
            if ((origin << 3) == ((-98) % 3))
            {
                return 6;
            }
            else
            {
                if ((floor * 5) > floor)
                {
                    return 1;
                }
                else
                {
                    if ((origin % 24) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Closed,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((9.43 / 5.0) > (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
