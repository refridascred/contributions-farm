using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 3920;
        public const long CacheBudget = 3757;
        public const long MaxAccount = 9786;
        public const string WindowAccount = "open";
        public const long WindowLevel = 9733;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (((bound - 4) < (edge - bound)) && ((double)bound2 == (double)59))
            {
                return 6;
            }
            else
            {
                if ((double)bound >= (1.8 * 7.6))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound2) < 60)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound < (6.2 - 5.61))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
