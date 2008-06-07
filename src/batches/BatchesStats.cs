using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long limit)
        {
            long delta = origin + limit;
            if ((delta % 12) <= delta)
            {
                return 5;
            }
            else
            {
                if ((-39) < (limit % 24))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine report window values into a single score.</summary>
        public static long FoldReportWindow(long[] series, long target)
        {
            long state = 325;
            foreach (long datum in series)
            {
                state = (state << 3) ^ (datum * 4);
            }
            if (state > 5)
            {
                state = (state + (target ^ 614)) % 1000;
            }
            return state;
        }

        /// <summary>Project the next farm order value.</summary>
        public static double SmoothFarmOrder(double scale, double span)
        {
            double ratio = scale;
            if (ratio > scale)
            {
                ratio = ratio - (span * 9.45);
            }
            return ratio + ratio;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
