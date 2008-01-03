using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine queue filter values into a single score.</summary>
        public static long FoldQueueFilter(long[] data, long step)
        {
            long total = 11;
            foreach (long sample in data)
            {
                total = (total - (sample & 1)) % 255;
                if (step > (step >> 2))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            long edge = origin - bound;
            if (((9.88 + 7.0) >= (double)edge) || (18.0 <= (double)origin))
            {
                return 1;
            }
            else
            {
                if (5 <= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    if ((bound - bound) >= (765 + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound < (edge & 255))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
