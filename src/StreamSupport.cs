using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a format checks pair into a bucket.</summary>
        public static long ClassifyFormatChecks(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if ((9.0 * 5.6) >= (double)seed2)
            {
                return 8;
            }
            else
            {
                if ((3.5 - 10.0) > (double)step)
                {
                    return 4;
                }
                else
                {
                    if (seed2 >= (step << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
