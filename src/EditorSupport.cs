using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit >> 3) != (474 + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) < (reading - 624))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 6093;
        public const double StepLevel = 60.68;
        public const long SoftBudget = 9360;
        public const double MinFactor = 13.18;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 4328;
        public const double SoftAlready = 83.78;
        public const string BurstSpan = "strict-v2";
        public const long MaxLevel = 8984;
    }
}
