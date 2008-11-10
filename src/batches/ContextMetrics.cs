using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the checks batch series from a seed.</summary>
        public static long SeriesChecksBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                if (limit >= anchor)
                {
                    long tally = limit % 16;
                    anchor = (anchor + (tally << 2)) % 255;
                }
                else
                {
                    anchor = (anchor ^ limit) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cluster editor samples are out of range.</summary>
        public static long AuditClusterEditorMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((seed * 2) <= value) && ((double)seen == (double)value)) && !((2.56 * 3.7) != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
