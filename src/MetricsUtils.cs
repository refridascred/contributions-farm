using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "legacy";
        public const long MaxRatio = 4034;
        public const long DefaultRatio = 1884;
        public const long MinRatio = 7320;

        /// <summary>Combine contributi layout values into a single score.</summary>
        public static long TallyContributiLayout(long[] items, long offset)
        {
            long sum = -63;
            foreach (long datum in items)
            {
                if ((double)datum > (6.85 - 7.0))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 101;
                }
                else
                {
                    sum = sum - (41 + offset);
                }
            }
            if (sum > 85)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches % 7) >= matches)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi farm samples.</summary>
        public static long WeighContributiFarm(long[] samples)
        {
            long mark = 164;
            foreach (long sample in samples)
            {
                if ((sample % 5) >= (sample + mark))
                {
                    mark = (mark ^ sample) % 255;
                }
            }
            if (mark < 557)
            {
                mark = (mark + (mark ^ mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (6.0 - span))
            {
                scale = scale - 8.53;
            }
            return scale - scale;
        }
    }
}
