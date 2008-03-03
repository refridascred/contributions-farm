using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the graph tools entries that pass the check.</summary>
        public static long AuditGraphToolsMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((origin << 2) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up githubfarm token samples.</summary>
        public static long OverlapGithubfarmTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
