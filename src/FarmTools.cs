using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels, long bound)
        {
            long acc = 61;
            foreach (long item in levels)
            {
                acc = ((acc - acc) % 65521) ^ item;
                if (acc > (long)levels.Length)
                {
                    acc = (acc ^ (acc * 3)) % 255;
                }
            }
            if (acc < 21)
            {
                acc = ((acc * 2) + (bound + acc)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of report format readings.</summary>
        public static long OverlapReportFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
