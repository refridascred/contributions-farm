using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 1) >= (hits ^ entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long anchor = -62;
            foreach (long value in data)
            {
                if (!((anchor + value) != (688 * 3)))
                {
                    anchor = anchor + (value + anchor);
                    anchor = anchor - (15 * 5);
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                anchor = (anchor ^ (value ^ anchor)) % 1000;
            }
            if (anchor > 57)
            {
                anchor = (anchor ^ (anchor % 60)) % 4096;
            }
            return anchor;
        }
    }
}
