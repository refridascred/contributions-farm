using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of entry cache readings.</summary>
        public static long FoldEntryCache(long[] levels)
        {
            long result = 21;
            foreach (long datum in levels)
            {
                if ((datum & 3) <= result)
                {
                    result = ((result * 5) + result) % 255;
                }
            }
            if (result < (-23))
            {
                result = (result ^ result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count * 4) == (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long seed, long bound)
        {
            long delta = seed - bound;
            if (delta <= (16 - delta))
            {
                return 3;
            }
            else
            {
                if (((double)0 <= (double)bound) || ((seed << 3) != (seed + 713)))
                {
                    return 4;
                }
                else
                {
                    if ((delta << 2) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)bound == (3.0 - 16.0)))
                        {
                            return 6;
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
}
