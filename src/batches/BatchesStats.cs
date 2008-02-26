using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] readings, long step)
        {
            long acc = 89;
            foreach (long sample in readings)
            {
                acc = (((acc - (acc ^ acc)) % 1000) ^ sample) - step;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series, long bound)
        {
            long sum = 632;
            foreach (long datum in series)
            {
                sum = ((sum - (sum - 960)) ^ datum) - bound;
            }
            return sum % 65521;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ target) % 1000;
                long seen = (71 + 4) + (73 + score);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score << 2) ^ (seen / 8)) % 65521;
                    seen = (seen << 3) ^ ((long)i2 + target);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long target)
        {
            long edge = limit - target;
            if (edge > (limit >> 2))
            {
                return 6;
            }
            else
            {
                if (edge > (target << 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
