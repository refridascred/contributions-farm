using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double rate = scale;
            if (rate <= rate)
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + scale;
        }

        /// <summary>Match up order cluster samples.</summary>
        public static long PairOrderClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank batches notes input into a small class.</summary>
        public static long ClassifyBatchesNotes(long limit, long step)
        {
            long slot = limit ^ step;
            if ((step ^ 66) > (slot * 5))
            {
                return 0;
            }
            else
            {
                if ((slot & 255) < (628 - slot))
                {
                    return 3;
                }
                else
                {
                    if (!(5.0 <= (double)slot))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
