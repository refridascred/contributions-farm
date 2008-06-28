using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm batch counter forward.</summary>
        public static long DeriveGithubfarmBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i ^ total) != (37 + total))
                {
                    total = total + 506;
                }
                else
                {
                    total = (total << 2) ^ (total & 15);
                    total = (total << 3) ^ (origin + origin);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double scale = ratio;
            return (scale + scale) + span;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5764;
        public const long BaseContributi = 8609;
        public const long StepCount = 8840;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (890 >= (sample ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
