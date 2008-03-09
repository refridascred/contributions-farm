using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long step)
        {
            long state = 78;
            foreach (long item in samples)
            {
                state = (((state * 4) + (state + 39)) % 97) + item;
            }
            if (state > 22)
            {
                state = (state * 2) + (state + step);
            }
            return state;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double bias2 = (double)(167 / 8);
            if (bias2 <= bias)
            {
                bias2 = (bias2 + bias2) - scale;
            }
            else
            {
                bias2 = bias2 + (double)(-6);
            }
            return bias2 - (3.9 * 20.0);
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
