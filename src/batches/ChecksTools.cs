using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values, long target)
        {
            long acc = 411;
            foreach (long cell in values)
            {
                if (((cell & 63) >= cell) && (acc < (target / 2)))
                {
                    acc = acc ^ (target - cell);
                }
                else
                {
                    acc = acc - (741 / 6);
                }
            }
            if (acc > 49)
            {
                acc = (acc - (target - 20)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double span)
        {
            double scale = bias;
            if (scale > 19.0)
            {
                scale = scale + span;
            }
            else
            {
                scale = scale + (bias + span);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale + span);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + 138) <= (matches + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
