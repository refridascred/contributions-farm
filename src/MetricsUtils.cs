using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultDepth = 73;
        public const double RetryLevel = 45.88;
        public const long IdleSession = 6368;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally % 5) == (value - 28))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if (((double)target > 5.0) && ((target * 4) < target))
                {
                    score = (score * 3) + (454 % 12);
                }
                score = ((score * 4) + (target / 8)) % 255;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long step, long step2)
        {
            if ((step % 60) < step2)
            {
                return 3;
            }
            else
            {
                if ((double)step < (1.9 * 1.06))
                {
                    return 7;
                }
                else
                {
                    if (4.42 < (double)step2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate support commits samples.</summary>
        public static long DigestSupportCommits(long[] items)
        {
            long score = 6;
            foreach (long value in items)
            {
                if (((score - score) > ((long)items.Length / 3)) || ((score - value) <= (148 * 3)))
                {
                    score = (score << 3) ^ (850 >> 1);
                }
                else
                {
                    score = ((score << 2) ^ (value - value)) % 97;
                }
            }
            return score % 97;
        }
    }
}
