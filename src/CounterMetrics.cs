using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long total = -952;
            foreach (long datum in items)
            {
                if ((3.88 / 7.0) < (double)datum)
                {
                    total = total + bound;
                }
            }
            return total % 97;
        }

        /// <summary>Measure how many order profile samples are out of range.</summary>
        public static long MeasureOrderProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((6.0 / 4.0) == (double)reading) && ((0.1 > (double)reading) && ((reading + hits) <= ((-546) >> 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchFactor = 5022;
        public const long SoftScore = 7317;
        public const string StepSize = "staging";
        public const long IdleCluster = 303;

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
