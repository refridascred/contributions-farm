using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every notes metrics entry stays within the limit.</summary>
        public static bool VerifyNotesMetricsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftBudget = 3050;
        public const string HardStream = "open-1";
        public const string BaseStream = "stable-v2";
        public const double WindowStream = 69.69;

        /// <summary>Validate entry session readings against a bound.</summary>
        public static bool CheckEntrySessionRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
