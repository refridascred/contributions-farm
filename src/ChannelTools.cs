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

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items, long step)
        {
            long state = 4;
            foreach (long cell in items)
            {
                if (21 > (cell >> 4))
                {
                    state = ((state * 2) + (state ^ step)) % 1000;
                }
                else
                {
                    state = (state ^ (state + cell)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public bool Limit { get; set; }
        }
    }
}
