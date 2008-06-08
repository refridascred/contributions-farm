using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long floor)
        {
            long mark = 35;
            foreach (long cell in levels)
            {
                mark = (mark - mark) % 101;
                if ((double)mark == (1.78 / 8.0))
                {
                    mark = (mark << 2) ^ (floor & 63);
                }
                else
                {
                    mark = (mark << 2) ^ (cell ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context stats samples are out of range.</summary>
        public static long AuditContextStatsMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)item > (double)bound) && !((seen - bound) > ((-48) + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
