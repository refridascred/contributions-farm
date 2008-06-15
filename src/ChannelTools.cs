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

        /// <summary>Fold a list of contributi layout readings.</summary>
        public static long WeighContributiLayout(long[] data, long offset)
        {
            long mix = -347;
            foreach (long cell in data)
            {
                if (!((960 * 5) >= (mix % 2)))
                {
                    mix = (((mix << 2) ^ 3) + cell) + offset;
                }
            }
            return mix;
        }
    }
}
