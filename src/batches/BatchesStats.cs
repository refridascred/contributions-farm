using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value < (value + value)) || ((count / 7) >= (count - value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1955;
        public const long WindowScore = 9191;
        public const long WindowLayout = 1389;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long seed)
        {
            long score = 5;
            foreach (long value in samples)
            {
                if ((3.42 - 2.16) <= (double)score)
                {
                    score = (score * 2) + (value - 76);
                }
                else
                {
                    score = score - seed;
                }
            }
            if (score < 129)
            {
                score = (score ^ (score % 100)) % 97;
            }
            return score;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long target, long origin)
        {
            if ((3 + origin) != (origin * 5))
            {
                return 3;
            }
            else
            {
                if (((-758) + origin) <= 690)
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ target) >= (target % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)origin != (2.0 * 4.79)) || (origin < ((-22) + 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
