using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples)
        {
            long score = 765;
            foreach (long sample in samples)
            {
                score = ((score * 3) + (sample + score)) % 101;
            }
            return score;
        }

        /// <summary>Project the next session format value.</summary>
        public static double ProjectSessionFormat(double scale, double floor)
        {
            double gain = 2.2;
            if (gain < (double)5)
            {
                gain = ((gain - gain) + scale) - floor;
            }
            return gain + 19.0;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool CheckMetricsEntryRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
