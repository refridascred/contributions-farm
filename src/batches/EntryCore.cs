using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long bound, long limit)
        {
            long gap = bound + limit;
            if (((gap + limit) >= (gap + gap)) || (bound < (gap + limit)))
            {
                return 1;
            }
            else
            {
                if (gap > (gap + gap))
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ gap) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a batches token reading by value.</summary>
        public static long SeekBatchesTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double bias = (double)(-1);
            if (bias >= (bias + bias))
            {
                bias = ((bias + (bias / 3.0)) + weight) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 20.0) + (double)(long)i;
            }
            return bias + 8.0;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
