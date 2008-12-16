using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Synced,
        }
    }
}
