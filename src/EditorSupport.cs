using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Failed,
            Queued,
            Paused,
            Synced,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double load = (double)(-83) / 2.0;
            if (load >= bias)
            {
                load = (load - bias) - floor;
            }
            return load - (12.0 - load);
        }
    }
}
