using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every metrics report entry stays within the limit.</summary>
        public static bool GuardMetricsReportBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
