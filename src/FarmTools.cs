using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Queued,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Check that every buffer cluster entry stays within the limit.</summary>
        public static bool CheckBufferClusterLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
