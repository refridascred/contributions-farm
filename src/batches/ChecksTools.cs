using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long offset)
        {
            long delta = limit - offset;
            if ((offset + delta) >= (limit % 60))
            {
                return 5;
            }
            else
            {
                if (((delta + delta) > limit) && ((double)limit == (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data, long limit)
        {
            long total = 6;
            foreach (long sample in data)
            {
                total = (total + limit) % 1000;
                total = (total - sample) % 97;
                if ((double)sample > (2.1 * 6.96))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Locked,
            Paused,
            Retry,
        }
    }
}
