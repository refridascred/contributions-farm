using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long seed)
        {
            long next = origin ^ seed;
            if ((next <= (next - origin)) || ((9 / 8) > (next - seed)))
            {
                return 8;
            }
            else
            {
                if ((seed - origin) != (93 * 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin <= (9.0 + 7.86))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.76 / 5.0) <= (double)next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
