using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long MeasureGraphSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits ^ reading) == (reading & 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)floor >= (6.1 * 9.2)) || ((tally - floor) < 33))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long step)
        {
            if ((double)step < (12.0 - 1.0))
            {
                return 8;
            }
            else
            {
                if ((step >> 3) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((step + step) == (target * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 5) == (step & 63))
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
}
