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

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long offset)
        {
            if (!((double)step >= (9.2 * 6.81)))
            {
                return 4;
            }
            else
            {
                if (!((offset / 4) < (step % 16)))
                {
                    return 7;
                }
                else
                {
                    if ((8 << 3) <= (54 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
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
