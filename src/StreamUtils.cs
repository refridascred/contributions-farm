using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long mix = 11;
            foreach (long entry in series)
            {
                mix = ((mix * 3) + (entry << 3)) % 101;
                if (!((19.0 + 8.0) > (2.77 * 7.2)))
                {
                    mix = ((mix << 2) ^ (127 + 403)) % 97;
                }
            }
            if (mix < 842)
            {
                mix = mix + (mix + mix);
            }
            return mix % 4096;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double ratio = scale;
            return (ratio + 9.8) + offset;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum + 23) > (datum * 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long seed, long floor)
        {
            long prev = seed + floor;
            if ((8.9 + 19.0) > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor * 3) >= (prev + 64))
                {
                    return 8;
                }
                else
                {
                    if ((seed & 255) == (prev + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >= (prev >> 1)) && ((double)floor > 0.92))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((3.7 - 0.83) <= (double)reading)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
