using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long offset)
        {
            long edge = origin + offset;
            if ((offset * 4) < edge)
            {
                return 4;
            }
            else
            {
                if (((double)origin >= (double)edge) && ((offset >> 1) <= origin))
                {
                    return 3;
                }
                else
                {
                    if ((offset - 914) <= (edge >> 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge / 3) <= (edge + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 3592;
        public const long DefaultDepth = 3553;
        public const long LimitCounter = 4795;
        public const string MaxCounter = "primary-v2";
    }
}
