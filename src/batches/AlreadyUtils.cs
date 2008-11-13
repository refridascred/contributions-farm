using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] data)
        {
            long total = 99;
            foreach (long cell in data)
            {
                total = total - cell;
                if (((double)cell <= 17.0) || ((double)cell == (10.0 * 11.0)))
                {
                    total = ((total << 3) ^ (cell - total)) % 1000;
                }
                else
                {
                    total = (total * 5) + (cell + total);
                }
            }
            return total % 65521;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item ^ (-2)) == (803 ^ tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((item - tally) <= (tally - 598)) || ((tally + tally) != (item - item)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double load = weight;
            if (load > offset)
            {
                load = load - load;
            }
            return load + (double)473;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + sample) == (sample << 3))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
