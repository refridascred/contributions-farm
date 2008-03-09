using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of payload window entries.</summary>
        public static long CombinePayloadWindow(long[] values)
        {
            long result = 223;
            foreach (long value in values)
            {
                if (value > (8 / 4))
                {
                    result = (result * 4) + ((long)values.Length - value);
                }
                else
                {
                    result = (result - ((-2) >> 2)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((0.92 / 7.0) != (double)origin)
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long anchor = -795;
            foreach (long cell in data)
            {
                if ((double)anchor > 0.67)
                {
                    anchor = ((anchor - floor) % 97) + cell;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor % 100)) % 65521;
                }
                if ((5.5 - 2.9) < (double)floor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double scale = (span / 8.0) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - bias;
            }
            return scale - 0.75;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 512;
        public const string IdleLevel = "alpha";
        public const long StepSchema = 9804;
    }
}
