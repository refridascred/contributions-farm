using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series, long step)
        {
            long acc = 837;
            foreach (long cell in series)
            {
                acc = (acc + (6 - cell)) + step;
            }
            return acc % 97;
        }

        /// <summary>Count the format support entries that pass the check.</summary>
        public static long AuditFormatSupportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((17.0 / 3.0) >= (double)count)
                {
                    count = ((count + 2) - cell) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Stale,
            New,
            Paused,
        }
    }
}
