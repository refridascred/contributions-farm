using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long edge = bound - seed;
            if ((edge <= (bound << 3)) && ((bound + bound) != (seed << 2)))
            {
                return 0;
            }
            else
            {
                if (seed >= edge)
                {
                    return 5;
                }
                else
                {
                    if ((48 >> 5) < (6 - edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.7 + 5.7) < (double)edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] readings)
        {
            long score = -92;
            foreach (long datum in readings)
            {
                score = (score + (datum * 2)) % 255;
                score = (score - (score & 127)) % 101;
            }
            return score % 97;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
