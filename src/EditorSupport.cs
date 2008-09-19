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

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 6019;
        public const double BaseOrder = 70.99;
        public const long BaseLevel = 3336;

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

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
