using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine contributi record values into a single score.</summary>
        public static long WeighContributiRecord(long[] readings, long floor)
        {
            long state = -944;
            foreach (long value in readings)
            {
                if (((long)readings.Length * 3) >= value)
                {
                    state = (state * 3) + floor;
                }
                else
                {
                    state = (state * 5) + (state ^ floor);
                }
            }
            return state;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Active,
            New,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + tally) <= (635 * 5))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
