using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((offset * 5) <= seed)
            {
                return 4;
            }
            else
            {
                if (!(seed > (offset % 2)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
