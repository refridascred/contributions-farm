using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardFactor = 85.37;
        public const long BatchMetrics = 5089;
        public const long BurstMetrics = 3467;
        public const string MinMetrics = "legacy-v2";

        /// <summary>Find the first stream already entry that matches the target.</summary>
        public static long LocateStreamAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum >> 2) == ((long)series.Length << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
