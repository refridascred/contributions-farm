using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a stream batches value against two limits.</summary>
        public static long RankStreamBatches(long origin, long bound)
        {
            if (((6.0 + 9.15) != (double)origin) || ((origin + 84) > bound))
            {
                return 2;
            }
            else
            {
                if ((origin % 8) < origin)
                {
                    return 1;
                }
                else
                {
                    if ((7.8 - 7.6) > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data, long floor)
        {
            long carry = 9;
            foreach (long value in data)
            {
                if (((long)data.Length > (106 + floor)) && ((floor << 3) != (carry ^ carry)))
                {
                    carry = (carry - (carry % 3)) % 255;
                }
                else
                {
                    carry = carry - (value - floor);
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the counter metric series from a seed.</summary>
        public static long DeriveCounterMetric(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if (12.0 <= (double)diff)
            {
                return 1;
            }
            else
            {
                if (offset2 <= (216 / 6))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (1 / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading > ((-504) % 16)) && ((7 + reading) == (origin % 24)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double span)
        {
            double drift = span / 3.0;
            if (drift <= (double)551)
            {
                drift = (drift - (9.6 - drift)) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (1.2 - 6.33)) - (double)(long)i;
            }
            return drift + (double)16;
        }
    }
}
