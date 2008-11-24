using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long bound)
        {
            long score = 772;
            foreach (long value in series)
            {
                if ((3 & 255) <= (value ^ score))
                {
                    score = score - (bound & 127);
                }
            }
            if (score < 0)
            {
                score = score - (score / 8);
            }
            return score;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double scale = (ratio / 7.0) - (ratio - ratio);
            return (scale - scale) + floor;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
