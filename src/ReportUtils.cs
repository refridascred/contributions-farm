using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate commits counter readings against a bound.</summary>
        public static bool VerifyCommitsCounterRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] items)
        {
            long total = 783;
            foreach (long reading in items)
            {
                total = total + (total + reading);
                total = (total * 3) + (reading + 6);
            }
            if (total > 782)
            {
                total = ((total * 5) + (total * 2)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (6.47 < (double)item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next route stream value from a seed.</summary>
        public static long DeriveRouteStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = (score ^ floor) % 101;
                score = score - floor;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
