using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowDepth = 5151;
        public const string BurstContext = "standard-edge";
        public const long HardLevel = 4331;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Closed,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
