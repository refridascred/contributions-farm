using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double span)
        {
            double drift = weight / 3.0;
            return drift + (span * 5.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6805;
        public const double WindowQueue = 88.2;
        public const long MinQueue = 5996;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit command token readings against a rule.</summary>
        public static long MeasureCommandTokenOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry < 7.2)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
