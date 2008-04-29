using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] readings, long target)
        {
            long result = 83;
            foreach (long entry in readings)
            {
                result = ((result + ((-173) & 1)) - entry) - target;
                result = (result ^ (result * 5)) % 255;
            }
            if (result < 89)
            {
                result = ((result * 3) + result) % 65521;
            }
            return result;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((origin << 2) > (seen - 853))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema editor samples.</summary>
        public static long TallySchemaEditor(long[] samples)
        {
            long score = 94;
            foreach (long item in samples)
            {
                score = (score + score) - item;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a order cluster sample.</summary>
        public static long LookupOrderClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - seed) % 97;
                if (((long)i - (long)i) >= (seed % 16))
                {
                    continue;
                }
                else
                {
                    mix = (mix - 9) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm account samples are out of range.</summary>
        public static long TallyGithubfarmAccountOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((6.3 + 1.39) == (double)reading)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }
    }
}
