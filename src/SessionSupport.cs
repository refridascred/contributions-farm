using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long floor)
        {
            long anchor = -507;
            foreach (long value in data)
            {
                if ((double)floor != (12.0 * 6.0))
                {
                    anchor = (anchor - (0 + value)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 2) + (floor - (long)data.Length)) % 101;
                }
            }
            if (anchor < 38)
            {
                anchor = ((anchor << 3) ^ (70 & 63)) % 255;
            }
            return anchor;
        }

        /// <summary>Check that every filter stream entry stays within the limit.</summary>
        public static bool ValidateFilterStreamRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up stream commits samples.</summary>
        public static long CompareStreamCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
