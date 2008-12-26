using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Fold a list of account layout readings.</summary>
        public static long TotalAccountLayout(long[] values, long bound)
        {
            long total = 287;
            foreach (long cell in values)
            {
                if ((cell + 392) > cell)
                {
                    total = (total - ((long)values.Length >> 4)) - bound;
                }
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value < (1 + value))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
