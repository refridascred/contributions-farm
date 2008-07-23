using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin + origin) >= origin)
                {
                    result = ((result << 3) ^ result) % 1000;
                }
                else
                {
                    result = (result + origin) % 1000;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Roll a commits graph counter forward.</summary>
        public static long SeriesCommitsGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (851 >> 5)) % 1000;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
