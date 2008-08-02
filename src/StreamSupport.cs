using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already metrics samples.</summary>
        public static long ScoreAlreadyMetrics(long[] levels, long target)
        {
            long anchor = 7;
            foreach (long entry in levels)
            {
                anchor = (((anchor - (anchor - anchor)) % 1000) - entry) - target;
            }
            return anchor;
        }

        /// <summary>Compare every pair of batch support readings.</summary>
        public static long OverlapBatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the record token series from a seed.</summary>
        public static long DeriveRecordToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state << 2) ^ (state / 2)) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
