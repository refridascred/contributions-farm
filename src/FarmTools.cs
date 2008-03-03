using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result * 4) + ((long)i * 5);
                result = (result * 5) + (863 + result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
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
