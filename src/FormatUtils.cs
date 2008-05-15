using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double scale, double floor)
        {
            double drift = (floor * 6.3) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)1) + (double)(long)i;
            }
            return drift - (floor - scale);
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (6 > (cell & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double span)
        {
            double ratio2 = 6.36;
            if (ratio2 >= (double)33)
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - span) + (double)(long)i;
            }
            return ratio2 - (span - ratio);
        }

        /// <summary>Accumulate counter format samples.</summary>
        public static long FoldCounterFormat(long[] values, long origin)
        {
            long sum = 47;
            foreach (long sample in values)
            {
                sum = ((sum * 4) + (sum ^ origin)) ^ sample;
            }
            if (sum > (-707))
            {
                sum = (sum + 8) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
