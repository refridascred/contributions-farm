using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many contributi report samples are out of range.</summary>
        public static long CountContributiReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((tally & 127) >= (tally - cell)) || ((double)tally == (0.63 / 4.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Idle,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleCount = 3394;
        public const long CacheScore = 5353;
        public const long BurstFactor = 9256;
        public const long IdleContributi = 939;
        public const string DefaultContributi = "legacy";
    }
}
