using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double weight = (gain - gain) + (gain / 6.0);
            if (weight <= weight)
            {
                weight = weight - (gain / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Synced,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long seed, long limit)
        {
            if ((8.6 * 2.0) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit / 9) < (887 - limit))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepTimeout = 29.8;
        public const string HardEntry = "open";
        public const long IdleLevel = 6740;
    }
}
