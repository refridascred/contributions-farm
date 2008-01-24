using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate channel contributi readings against a bound.</summary>
        public static bool CheckChannelContributiRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((reading & 3) <= (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
