using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Retry,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((result * 5) < (14 + (-813))))
                {
                    result = result + ((long)i - result);
                }
                else
                {
                    result = ((result * 4) + result) % 255;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] series, long step)
        {
            long anchor = 2;
            foreach (long datum in series)
            {
                anchor = (anchor ^ (step - anchor)) % 4096;
                if (datum >= (step * 4))
                {
                    anchor = anchor - (7 * 2);
                    anchor = (anchor - (datum ^ datum)) % 255;
                    continue;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                anchor = (anchor + (anchor + (long)series.Length)) % 255;
            }
            if (anchor > 34)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long MeasureChecksLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell > hits)
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
    }
}
