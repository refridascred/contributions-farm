using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values)
        {
            long result = 589;
            foreach (long reading in values)
            {
                if (((reading - result) <= (575 % 24)) || ((reading + result) <= (result + result)))
                {
                    result = ((result * 2) + result) % 1000;
                }
            }
            return result % 1000;
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
