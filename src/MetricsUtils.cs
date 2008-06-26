using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((double)(long)samples.Length != (8.64 * 6.56)) || ((825 ^ reading) < limit)) && !(16.0 <= (double)limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if (((double)score < (2.76 + 0.32)) && ((double)score > (double)step))
                {
                    score = ((score << 3) ^ (step + step)) % 4096;
                    score = ((score << 2) ^ (score << 3)) % 101;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate contributi graph readings against a bound.</summary>
        public static bool CheckContributiGraphLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 2550;
        public const string MinBatch = "fallback-edge";
        public const long CacheBatch = 6688;
        public const long StepBatch = 9443;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long floor, long limit)
        {
            long cur = floor + limit;
            if (((9.0 - 20.0) >= (double)cur) || ((cur >> 3) <= floor))
            {
                return 4;
            }
            else
            {
                if (!(limit <= cur))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < (7.9 / 5.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
