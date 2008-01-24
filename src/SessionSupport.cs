using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "staging";
        public const string WindowSize = "open-edge";
        public const string BurstFactor = "open-edge";
        public const long MaxFactor = 4787;
        public const string BurstEntry = "open-v2";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading == (double)671)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Grade a account editor value against two limits.</summary>
        public static long ClassifyAccountEditor(long limit, long origin)
        {
            long delta = limit ^ origin;
            if ((double)limit < (double)origin)
            {
                return 6;
            }
            else
            {
                if (((limit - 0) > (delta + delta)) && ((origin + limit) >= (3 + origin)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
