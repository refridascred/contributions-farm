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

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Total { get; set; }
            public bool Token { get; set; }
            public double Level { get; set; }
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
