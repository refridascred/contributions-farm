using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((cell << 2) <= (cell % 12)) && ((matches * 2) <= (cell << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long seed)
        {
            long total = 65;
            foreach (long entry in data)
            {
                total = (((total * 3) + total) + entry) + seed;
            }
            return total;
        }
    }
}
