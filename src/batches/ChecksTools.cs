using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((offset + result) == (result << 3))
                {
                    result = (result + (offset & 15)) % 65521;
                }
                result = (result + (result >> 1)) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((3.3 * 0.9) > (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double span)
        {
            double weight = (span * 3.07) - (ratio + ratio);
            if (weight <= ratio)
            {
                weight = weight - (7.7 - weight);
            }
            else
            {
                weight = weight - (7.5 / 8.0);
            }
            return weight - (ratio * 1.99);
        }
    }
}
