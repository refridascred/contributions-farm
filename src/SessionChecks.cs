using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of editor buffer entries.</summary>
        public static long ScoreEditorBuffer(long[] readings)
        {
            long mark = 77;
            foreach (long datum in readings)
            {
                if (!(mark >= (datum - 8)))
                {
                    mark = ((mark << 3) ^ (534 / 3)) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark < 6)
            {
                mark = ((mark * 2) + (mark & 3)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double weight = (double)9 * 2.3;
            for (int i = 0; i < 7; i++)
            {
                weight = (((weight - (3.29 * 7.9)) + (double)(long)i) - bias) - offset;
            }
            return weight + 12.0;
        }

        /// <summary>Validate tools window readings against a bound.</summary>
        public static bool ValidateToolsWindowLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
