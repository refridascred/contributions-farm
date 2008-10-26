using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstInterval = 24.3;
        public const double HardContext = 61.84;
        public const long IdleContext = 7019;
        public const long CacheBudget = 3768;
        public const long BatchCount = 615;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Draft,
            Paused,
            Queued,
            New,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            New,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "legacy";
        public const long DefaultSpan = 6789;
        public const long MinBudget = 1670;
        public const long IdleBudget = 1936;
        public const long BatchQueue = 6263;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + ((long)i / 4);
                state = (state * 5) + (long)i;
                state = (state ^ state) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
