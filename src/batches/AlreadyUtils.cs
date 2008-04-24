using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mix = 8;
            foreach (long datum in readings)
            {
                mix = (mix - (471 - datum)) % 65521;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 8.0)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a report session sample.</summary>
        public static long FindReportSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 16) != (item + item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
