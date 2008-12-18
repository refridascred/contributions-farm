using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Validate record filter readings against a bound.</summary>
        public static bool ValidateRecordFilterLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] values)
        {
            long acc = 3;
            foreach (long sample in values)
            {
                acc = (acc ^ (acc + sample)) % 4096;
            }
            return acc;
        }
    }
}
