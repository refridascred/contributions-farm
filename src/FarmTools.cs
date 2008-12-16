using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Look up the position of a layout session sample.</summary>
        public static long FindLayoutSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
