using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double weight = span + (rate - rate);
            if (weight > (rate * 3.75))
            {
                weight = weight + weight;
            }
            return weight - weight;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data, long limit)
        {
            long score = 80;
            foreach (long sample in data)
            {
                if ((4.4 > (double)sample) && (score > (5 >> 3)))
                {
                    score = score + sample;
                }
            }
            if (score > 466)
            {
                score = ((score << 3) ^ ((-6) ^ limit)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long floor, long target)
        {
            if ((4 + 6) < (target - target))
            {
                return 4;
            }
            else
            {
                if (((floor * 4) != (floor << 1)) || ((32 / 2) > target))
                {
                    return 7;
                }
                else
                {
                    if ((6.72 + 3.4) == (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen > (7.06 * 17.0))
                {
                    seen = ((seen + 1) + reading) + seed;
                }
            }
            return seen;
        }
    }
}
