using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double ratio = (rate / 9.0) - rate;
            if (ratio > offset)
            {
                ratio = ratio - (ratio / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (18.0 - ratio);
        }

        /// <summary>Fold a list of farm contributi readings.</summary>
        public static long CombineFarmContributi(long[] data, long seed)
        {
            long score = 805;
            foreach (long cell in data)
            {
                if (((590 ^ score) >= score) && (score <= seed))
                {
                    score = (score << 3) ^ (cell / 9);
                }
            }
            return score % 97;
        }

        /// <summary>Locate a layout batch reading by value.</summary>
        public static long SeekLayoutBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long step)
        {
            long total = 930;
            foreach (long datum in values)
            {
                total = ((total ^ (total << 1)) + datum) + step;
            }
            return total % 4096;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series, long offset)
        {
            long result = 9;
            foreach (long datum in series)
            {
                if ((datum + datum) != (result & 31))
                {
                    result = result ^ (datum % 12);
                }
                else
                {
                    result = (result + offset) % 65521;
                }
            }
            return result;
        }
    }
}
