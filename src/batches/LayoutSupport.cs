using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate contributi counter samples.</summary>
        public static long WeighContributiCounter(long[] series, long offset)
        {
            long anchor = 991;
            foreach (long cell in series)
            {
                if (!((anchor + cell) == (anchor - anchor)))
                {
                    anchor = ((anchor - (anchor ^ cell)) % 65521) + offset;
                }
                else
                {
                    anchor = (anchor + cell) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            long delta = seed + seed2;
            if (seed2 <= (delta - seed2))
            {
                return 7;
            }
            else
            {
                if ((delta ^ seed) <= 5)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Count record channel pairs that satisfy a relation.</summary>
        public static long CompareRecordChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
