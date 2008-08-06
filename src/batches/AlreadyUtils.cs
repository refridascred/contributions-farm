using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((3.9 * 19.0) < (double)hits) || (((9 << 2) != (sample - 94)) || ((hits + sample) < (sample % 60))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long seed)
        {
            if (!(bound < (901 + (-6))))
            {
                return 8;
            }
            else
            {
                if ((bound * 4) >= (599 + seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed - seed) != (bound ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)76 < (double)seed)
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
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples, long limit)
        {
            long score = -5;
            foreach (long value in samples)
            {
                score = (((score * 2) + (value - score)) % 255) - limit;
            }
            return score;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Adjust a farm payload reading.</summary>
        public static double ScaleFarmPayload(double ratio, double span)
        {
            double gain = 3.71 / 8.0;
            if (gain >= span)
            {
                gain = (gain + (double)95) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - span;
        }
    }
}
