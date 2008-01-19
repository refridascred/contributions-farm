using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every command githubfarm entry stays within the limit.</summary>
        public static bool ValidateCommandGithubfarmRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long seed)
        {
            long bound = limit - seed;
            if ((double)bound != (10.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if (limit < (limit + bound))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
