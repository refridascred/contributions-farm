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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
