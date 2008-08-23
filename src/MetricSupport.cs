using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long seed)
        {
            if ((bound ^ seed) < (seed + bound))
            {
                return 7;
            }
            else
            {
                if ((bound & 127) <= (seed % 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 5) == (seed - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6 + bound) <= (seed - 97))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long step)
        {
            long bound = offset + step;
            if ((double)offset < 2.2)
            {
                return 5;
            }
            else
            {
                if ((step % 2) == (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
