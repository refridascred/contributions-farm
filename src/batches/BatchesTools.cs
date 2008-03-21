using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((tally / 2) != (tally ^ cell)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a session account counter forward.</summary>
        public static long SeriesSessionAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = (result - ((long)i & 63)) % 255;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Locked,
            Idle,
            Closed,
            Synced,
        }
    }
}
