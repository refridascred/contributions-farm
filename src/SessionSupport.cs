using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel checks samples are out of range.</summary>
        public static long CountChannelChecksMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ 118) > (6 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first token stats entry that matches the target.</summary>
        public static long SeekTokenStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
