using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 1592;
        public const double HardDepth = 83.42;
        public const long LimitRatio = 1941;
        public const long HardWidth = 2140;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Stale,
            Locked,
            Active,
            Synced,
        }
    }
}
