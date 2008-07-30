using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a route editor figure with a bias.</summary>
        public static double BlendRouteEditor(double weight, double span)
        {
            double scale = (span - span) - (double)6;
            if (scale > (double)0)
            {
                scale = (scale + (double)1) + weight;
            }
            else
            {
                scale = scale + (double)906;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 8508;
        public const long MinEntry = 594;
        public const string HardEntry = "strict-1";

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 2) + mark) % 255;
                mark = (mark ^ (mark - (long)i)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double drift = (double)((-400) << 3);
            if (drift >= (double)307)
            {
                drift = drift - (bias / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (bias2 * 5.4);
        }

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
