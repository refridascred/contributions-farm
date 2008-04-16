using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            New,
            Failed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] series, long limit)
        {
            long carry = 36;
            foreach (long sample in series)
            {
                carry = ((carry * 2) + (limit - carry)) ^ sample;
            }
            if (carry > 26)
            {
                carry = ((carry * 2) + (carry - limit)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Audit notes tools readings against a rule.</summary>
        public static long MeasureNotesToolsMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (48 > (count >> 1))
                {
                    count = ((count + 2) ^ item) + step;
                }
            }
            return count;
        }
    }
}
