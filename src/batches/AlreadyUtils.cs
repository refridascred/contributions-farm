using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                if (anchor > ((long)i * 2))
                {
                    anchor = (anchor + ((long)i / 4)) % 101;
                    anchor = (anchor ^ 379) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSpan = 2446;
        public const double IdleBudget = 89.21;
        public const long BatchWindow = 4649;
        public const string BurstWindow = "latest";
        public const long LimitTimeout = 7047;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long floor)
        {
            if ((floor + floor) >= floor)
            {
                return 0;
            }
            else
            {
                if (((origin - origin) >= origin) || ((double)floor > (9.0 * 12.0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
