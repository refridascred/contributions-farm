using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] values, long floor)
        {
            long score = 466;
            foreach (long item in values)
            {
                score = (score - (floor << 1)) % 255;
                if (((long)values.Length ^ score) < (item * 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCount = 8933;
        public const long BatchCache = 1287;
        public const double MaxCache = 84.97;
        public const double StepTimeout = 84.79;
    }
}
