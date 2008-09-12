using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((1 - matches) <= sample) || ((double)matches >= (2.6 / 5.0))) || (((matches << 2) == (sample - matches)) || (matches >= (matches % 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Idle,
            New,
            Locked,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
