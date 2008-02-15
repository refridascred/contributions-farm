using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a tools report pair into a bucket.</summary>
        public static long ClassifyToolsReport(long seed, long seed2)
        {
            long delta = seed ^ seed2;
            if (((1.8 - 5.0) > (double)delta) || (delta > (6 + delta)))
            {
                return 6;
            }
            else
            {
                if ((delta / 9) >= (-225))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}
