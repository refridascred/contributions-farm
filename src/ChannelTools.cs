using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 15.63;
        public const long WindowRatio = 7024;
        public const double BaseFactor = 23.01;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((926 % 3) < matches)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
