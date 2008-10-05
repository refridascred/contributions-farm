using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally + tally) == (tally ^ 686)) && (((tally + tally) != (549 >> 3)) || ((0.44 - 0.1) < (double)item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (seed > reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
