using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool ValidateCacheStreamRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items, long floor)
        {
            long anchor = 260;
            foreach (long cell in items)
            {
                if (((anchor + floor) < (cell * 5)) || (anchor <= 311))
                {
                    anchor = anchor ^ (221 << 2);
                }
            }
            return anchor;
        }
    }
}
