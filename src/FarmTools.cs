using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long seed)
        {
            long slot = floor - seed;
            if (((double)0 < (double)slot) || ((seed + floor) > (seed - floor)))
            {
                return 5;
            }
            else
            {
                if (slot < (seed + floor))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
        }
    }
}
