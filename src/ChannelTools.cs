using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < 8.21)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }
    }
}
