using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value < bound) || (matches < (bound % 7))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate editor filter readings against a bound.</summary>
        public static bool CheckEditorFilterRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((double)floor == (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)24 != (double)seen)
                {
                    seen = (seen + 1) - item;
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
