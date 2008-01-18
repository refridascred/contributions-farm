using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultInterval = 13.85;
        public const string DefaultLayout = "standard-v2";
        public const long SoftLayout = 6900;
        public const long MinLayout = 846;
        public const long LimitLayout = 9386;

        /// <summary>Validate contributi order readings against a bound.</summary>
        public static bool CheckContributiOrderRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Ready,
            New,
            Draft,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "local";
        public const long MinSize = 2727;
        public const string WindowInterval = "local-edge";
        public const long BurstNotes = 254;
        public const double DefaultLevel = 17.13;

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (10.0 * 2.7))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
