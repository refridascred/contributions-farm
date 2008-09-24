using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two cluster graph measurements.</summary>
        public static double ProjectClusterGraph(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (bias + 2.5)) - (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Accumulate cluster buffer samples.</summary>
        public static long ScoreClusterBuffer(long[] data)
        {
            long mark = 7;
            foreach (long reading in data)
            {
                if (!((mark - reading) > (mark << 3)))
                {
                    mark = ((mark * 5) + ((-71) << 3)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 < bias)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + offset) + (double)(long)i;
            }
            return bias2 + (double)(-824);
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate already order readings against a bound.</summary>
        public static bool VerifyAlreadyOrderLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
