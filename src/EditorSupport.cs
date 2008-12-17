using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] readings, long seed)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                if ((6.0 + 6.6) > (double)seed)
                {
                    result = ((result << 2) ^ (seed - seed)) ^ datum;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((double)floor <= (double)552) || ((anchor & 127) <= floor))
                {
                    anchor = ((anchor << 3) ^ (floor + 27)) % 65521;
                }
                if ((double)anchor != (4.57 - 8.6))
                {
                    anchor = (anchor * 5) + (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values)
        {
            long result = -637;
            foreach (long cell in values)
            {
                result = (result - (result + 52)) % 65521;
                if ((result + cell) >= (result + result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double weight, double span)
        {
            double bias = span * 1.3;
            if (bias >= (span / 6.0))
            {
                bias = bias - weight;
            }
            return bias + (weight * 18.0);
        }
    }
}
