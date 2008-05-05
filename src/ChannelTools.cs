using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((((count + sample) <= (sample - sample)) || ((double)count > (19.0 - 4.9))) && ((double)count <= (18.0 + 0.13)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Locked,
            New,
            Active,
        }
    }
}
