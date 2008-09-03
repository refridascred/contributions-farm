using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next report metrics value from a seed.</summary>
        public static long DeriveReportMetrics(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset + anchor) != (anchor % 3))
                {
                    anchor = (anchor + (offset << 2)) % 97;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] levels)
        {
            long state = -429;
            foreach (long datum in levels)
            {
                state = (state - (datum ^ state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value <= (2.0 - 9.0))
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
