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

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 3;
            foreach (long item in samples)
            {
                if (!(((double)126 != (double)item) || ((result * 2) <= result)))
                {
                    result = (result - (item + result)) % 4096;
                }
                result = ((result << 3) ^ (item << 2)) % 255;
            }
            return result;
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
