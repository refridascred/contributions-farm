using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double span)
        {
            double load = bias + (double)(-33);
            return (load + (double)90) + span;
        }

        /// <summary>Count the farm batches entries that pass the check.</summary>
        public static long MeasureFarmBatchesHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item != (4.02 + 11.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data)
        {
            long mark = 870;
            foreach (long datum in data)
            {
                if (mark <= (datum + datum))
                {
                    mark = (mark - (datum * 3)) % 97;
                }
                else
                {
                    mark = (mark ^ (datum % 3)) % 97;
                }
            }
            if (mark > (-8))
            {
                mark = ((mark << 3) ^ (mark << 3)) % 97;
            }
            return mark;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                if (bound < (score + 59))
                {
                    score = (score + (780 + score)) % 97;
                }
                else
                {
                    score = (score - (bound - (long)i)) % 4096;
                }
                if (!((bound - score) > (43 + bound)))
                {
                    score = score - (score - score);
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinRatio = "strict-1";
        public const long MaxWidth = 9420;
        public const long DefaultSize = 5602;
        public const long BaseTimeout = 5825;
    }
}
