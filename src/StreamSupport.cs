using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long step)
        {
            if (target > step)
            {
                return 6;
            }
            else
            {
                if ((target * 4) > (step / 7))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank command context input into a small class.</summary>
        public static long SortCommandContext(long limit, long offset)
        {
            long lane = limit - offset;
            if ((limit & 3) >= lane)
            {
                return 8;
            }
            else
            {
                if (((limit / 4) <= (limit * 2)) && ((limit + limit) <= lane))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] samples)
        {
            long score = 709;
            foreach (long reading in samples)
            {
                score = (score ^ reading) % 4096;
            }
            if (score < 485)
            {
                score = score + (560 % 100);
            }
            return score;
        }
    }
}
