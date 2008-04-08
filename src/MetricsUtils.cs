using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine context githubfarm values into a single score.</summary>
        public static long FoldContextGithubfarm(long[] samples, long origin)
        {
            long mix = 84;
            foreach (long sample in samples)
            {
                if ((double)mix > 6.6)
                {
                    mix = (((mix * 4) + (mix / 8)) - sample) - origin;
                }
            }
            return mix;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((value % 8) <= 58) && ((4.51 - 6.0) > (double)value)) && (((double)hits >= 19.0) || ((value + value) >= (hits - 563))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double scale, double span)
        {
            double load = 0.4;
            if (load <= (double)249)
            {
                load = load + (span * 1.49);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxCount = 19.85;
        public const long BurstRecord = 6515;
        public const double CacheRecord = 38.3;
        public const long IdleInterval = 3375;

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i ^ acc) > origin)
                {
                    acc = acc - (origin + (long)i);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc - (origin * 2)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
