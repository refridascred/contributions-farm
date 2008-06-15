using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] data)
        {
            long score = 35;
            foreach (long item in data)
            {
                score = (score ^ (score << 1)) % 1000;
                score = score ^ (item - score);
                if ((double)score >= (19.0 + 15.0))
                {
                    score = score - item;
                }
            }
            if (score < 76)
            {
                score = score + (score >> 3);
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(7 < (sample ^ 658)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (mix << 2);
                if (((double)floor > (0.76 / 7.0)) && ((double)(long)i < 5.59))
                {
                    mix = mix - (mix - (long)i);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long AuditChecksSchemaOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits + 4) != (sample & 15))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next graph notes value.</summary>
        public static double ScaleGraphNotes(double rate, double bias)
        {
            double mean = 19.0;
            if (mean > mean)
            {
                mean = (mean - bias) + rate;
            }
            else
            {
                mean = mean - (bias * 18.0);
            }
            return mean + (20.0 * 20.0);
        }
    }
}
