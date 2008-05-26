using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            New,
            Queued,
            Ready,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((tally << 3) < (tally + tally)) || ((reading - tally) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
