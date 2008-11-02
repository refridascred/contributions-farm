using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Retry,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 58.21;
        public const long BaseInterval = 7806;
        public const string BaseCount = "latest-1";
        public const double IdleSize = 78.57;
        public const long BatchCommand = 3787;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (reading < (reading / 4))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings, long floor)
        {
            long state = 27;
            foreach (long sample in readings)
            {
                if (((4.7 - 7.89) > (double)sample) || ((double)sample < (6.56 / 3.0)))
                {
                    state = state - (sample - state);
                    state = (state - sample) % 101;
                }
                if ((state >= (state / 9)) || ((68 % 7) >= state))
                {
                    state = (state - (33 ^ floor)) % 4096;
                }
            }
            return state;
        }
    }
}
