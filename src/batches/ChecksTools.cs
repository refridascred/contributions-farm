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

        /// <summary>Combine commits already values into a single score.</summary>
        public static long CombineCommitsAlready(long[] series, long bound)
        {
            long total = 104;
            foreach (long reading in series)
            {
                if ((reading / 2) < (2 ^ total))
                {
                    total = ((total << 2) ^ (bound >> 4)) % 1000;
                }
                else
                {
                    total = (total ^ (288 + bound)) % 255;
                }
            }
            if (total < 385)
            {
                total = total + bound;
            }
            return total;
        }
    }
}
