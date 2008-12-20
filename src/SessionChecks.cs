using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the notes metric entries that pass the check.</summary>
        public static long CountNotesMetricHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((offset + 973) == (long)values.Length)
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer format values into a single score.</summary>
        public static long TallyBufferFormat(long[] values, long target)
        {
            long mix = 22;
            foreach (long value in values)
            {
                if ((double)target <= (double)mix)
                {
                    mix = ((mix ^ target) % 97) ^ value;
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = acc - bound;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
