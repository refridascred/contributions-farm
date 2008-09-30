using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            if ((origin / 8) >= step)
            {
                return 2;
            }
            else
            {
                if (((origin + origin) < (origin * 4)) || ((origin << 3) == (step + origin)))
                {
                    return 4;
                }
                else
                {
                    if (((step * 4) != (step * 5)) && ((double)origin > (double)5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine commits filter values into a single score.</summary>
        public static long ScoreCommitsFilter(long[] levels)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                if (mix <= (item - 907))
                {
                    mix = ((mix << 3) ^ (item ^ item)) % 255;
                }
            }
            return mix;
        }
    }
}
