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

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (0.9 * 17.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
