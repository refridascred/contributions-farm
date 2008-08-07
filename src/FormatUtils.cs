using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 90.01;
        public const long RetryFormat = 7461;
        public const long BurstFormat = 8884;
        public const string BurstInterval = "cached-1";
        public const string WindowFormat = "local-edge";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((8.4 - 5.0) < (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + (target + target)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor + (target + target)) - (long)i2;
                }
                anchor = anchor - (target * 3);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 6.17;
        public const long BatchScore = 6334;
        public const double WindowSupport = 90.4;
        public const long RetrySupport = 609;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            New,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            New,
            Ready,
            Idle,
            Failed,
        }
    }
}
