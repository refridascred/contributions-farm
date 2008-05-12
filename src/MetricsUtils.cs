using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Failed,
            Active,
            New,
            Done,
        }

        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool VerifyChecksSchemaLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double mean = 7.5;
            if (mean <= span)
            {
                mean = (mean - (double)420) - ratio;
            }
            return mean + 5.0;
        }

        /// <summary>Blend two graph route measurements.</summary>
        public static double AdjustGraphRoute(double scale, double bias)
        {
            double ratio = 1.53 + (5.73 * 4.4);
            if (ratio <= (double)293)
            {
                ratio = (ratio - scale) + bias;
            }
            else
            {
                ratio = ratio - (double)8;
            }
            return ratio + (double)4;
        }
    }
}
