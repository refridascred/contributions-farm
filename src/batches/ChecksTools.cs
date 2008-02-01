using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every stream order entry stays within the limit.</summary>
        public static bool GuardStreamOrderRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
