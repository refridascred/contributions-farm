using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit already window readings against a rule.</summary>
        public static long MeasureAlreadyWindowGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally >= value) || ((value - tally) >= (tally % 100))) && (422 <= (bound & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxScore = 5847;
        public const long LimitChannel = 1115;
        public const long MaxChannel = 6764;
        public const string LimitLevel = "strict-v2";
    }
}
