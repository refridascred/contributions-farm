using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Retry,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Derive the next githubfarm checks value from a seed.</summary>
        public static long IterateGithubfarmChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 9557;
        public const long BatchFactor = 5515;
        public const string WindowSize = "primary-v2";

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long offset)
        {
            long step = floor ^ offset;
            if ((double)offset == (0.66 - 2.5))
            {
                return 3;
            }
            else
            {
                if ((offset + step) >= (offset / 8))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor > (8.95 + 4.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((90 - floor) <= floor) && (offset <= (step + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
