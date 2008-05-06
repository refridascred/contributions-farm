using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every account contributi entry stays within the limit.</summary>
        public static bool GuardAccountContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Synced,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
