using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Count the notes editor entries that pass the check.</summary>
        public static long MeasureNotesEditorHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches << 2) > (matches & 1))
                {
                    matches = ((matches + 1) - cell) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen <= (45 & 7)) || ((value + value) > 4)) && !(((long)series.Length + value) != (seen + value)))
                {
                    seen = seen + 2;
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
