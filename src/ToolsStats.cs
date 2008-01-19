using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the report stream entries that pass the check.</summary>
        public static long MeasureReportStreamMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((8 & 15) <= (7 + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 72.53;
        public const string MinEntry = "local-edge";
        public const long StepSpan = 934;
        public const long MaxEntry = 6735;
        public const long MinSize = 8302;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = (result - result) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many payload editor samples are out of range.</summary>
        public static long CountPayloadEditorMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((double)seed <= (double)datum) || (4.35 < (double)seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((bound >> 5) == ((long)i - bound)) || (bound < (bound % 24)))
                {
                    total = (total + (long)i) % 101;
                    total = ((total * 3) + (bound & 31)) % 4096;
                    break;
                }
                else
                {
                    total = ((total * 3) + (bound + total)) % 101;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
