using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of profile order readings.</summary>
        public static long MatchProfileOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Done,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (item <= (tally % 5))
                {
                    tally = (tally + 2) + origin;
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
