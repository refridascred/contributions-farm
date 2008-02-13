using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit format filter readings against a rule.</summary>
        public static long TallyFormatFilterMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + 437) > (count - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((16 + value) < (51 / 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] readings, long floor)
        {
            long anchor = 86;
            foreach (long datum in readings)
            {
                anchor = ((anchor - (5 + datum)) % 1000) - floor;
            }
            return anchor;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double bias = (double)86 / 2.0;
            if (bias < (scale * 8.19))
            {
                bias = bias + (double)9;
            }
            return bias - span;
        }
    }
}
