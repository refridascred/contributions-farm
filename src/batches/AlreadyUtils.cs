using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Done,
            Failed,
            New,
            Dropped,
        }

        /// <summary>Check that every format tools entry stays within the limit.</summary>
        public static bool ValidateFormatToolsLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
