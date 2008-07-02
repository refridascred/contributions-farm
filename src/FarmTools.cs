using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double weight, double bias)
        {
            double bias2 = (bias / 9.0) - (weight - bias);
            return bias2 + bias2;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8 - bound) >= seen)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }
    }
}
