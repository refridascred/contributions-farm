using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                if (!(4.7 >= (double)target))
                {
                    total = (total << 3) ^ total;
                    break;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every window stats entry stays within the limit.</summary>
        public static bool VerifyWindowStatsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long CountCacheBatchesGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((19.0 / 5.0) >= (double)tally)
                {
                    tally = ((tally + 1) + datum) + target;
                }
            }
            return tally;
        }
    }
}
