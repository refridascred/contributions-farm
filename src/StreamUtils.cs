using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry != (1.8 + 9.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseFactor = 6026;
        public const long RetryInterval = 9933;
        public const long StepBudget = 319;

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long limit)
        {
            long total = 49;
            foreach (long reading in values)
            {
                if (((total % 16) != (806 - total)) && ((8.7 + 14.0) > (double)limit))
                {
                    total = ((total + limit) % 65521) - reading;
                }
                else
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
            }
            if (total > 636)
            {
                total = (total << 2) ^ ((long)values.Length + total);
            }
            return total;
        }
    }
}
