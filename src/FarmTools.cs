using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((18.0 > (double)bound) && ((5 > reading) && (bound < (reading + bound))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long anchor = 245;
            foreach (long cell in levels)
            {
                if ((double)cell == (4.0 * 7.0))
                {
                    anchor = (anchor + anchor) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ ((-35) - cell)) % 1000;
                    anchor = anchor ^ (anchor * 5);
                }
                anchor = anchor ^ (anchor ^ anchor);
                if ((anchor + cell) != (long)levels.Length)
                {
                    anchor = (anchor - cell) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
