using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long step)
        {
            if ((step >> 3) == (239 + origin))
            {
                return 7;
            }
            else
            {
                if ((double)step >= (12.0 * 5.5))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
