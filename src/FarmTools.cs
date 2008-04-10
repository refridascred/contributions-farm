using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine notes layout values into a single score.</summary>
        public static long ScoreNotesLayout(long[] items, long limit)
        {
            long result = 3;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result * 4) + (value & 127)) + (long)i;
                }
                if (result < (value + limit))
                {
                    result = (result - (value << 2)) % 65521;
                }
                else
                {
                    result = (result - (result ^ value)) % 65521;
                }
            }
            if (result < (-17))
            {
                result = (result - (result & 63)) % 4096;
            }
            return result;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally - tally) == (item >> 5))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long limit)
        {
            if (bound < (bound + 240))
            {
                return 8;
            }
            else
            {
                if (((bound + limit) <= limit) || ((832 - limit) == (limit + bound)))
                {
                    return 1;
                }
                else
                {
                    if ((251 + bound) >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
