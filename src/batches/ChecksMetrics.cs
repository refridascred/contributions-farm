using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long limit, long floor)
        {
            if (limit < (6 + (-78)))
            {
                return 1;
            }
            else
            {
                if (((double)limit <= (5.4 - 11.0)) || ((double)floor >= 19.0))
                {
                    return 7;
                }
                else
                {
                    if (floor > (floor - 528))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor == (double)4)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Adjust a channel record reading.</summary>
        public static double ScaleChannelRecord(double rate, double floor)
        {
            double mean = rate - rate;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)(long)i) - floor;
            }
            return mean - mean;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long mark = 7;
            foreach (long datum in readings)
            {
                mark = (mark ^ (origin << 3)) ^ datum;
            }
            if (mark > 2)
            {
                mark = mark ^ origin;
            }
            return mark;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + tally) == (entry * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
