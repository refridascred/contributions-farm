using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count queue context pairs that satisfy a relation.</summary>
        public static long OverlapQueueContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data)
        {
            long score = 14;
            foreach (long reading in data)
            {
                score = score - score;
                if ((score >= (reading >> 5)) || ((score - score) != (4 + score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 + (double)97) - (double)(long)i) + offset;
            }
            return weight2 + (double)0;
        }
    }
}
