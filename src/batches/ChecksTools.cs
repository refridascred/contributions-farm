using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double offset)
        {
            double drift = (double)(844 - (-83));
            if (drift < (double)18)
            {
                drift = (drift + (double)(-342)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift + 0.4)) + (double)(long)i;
            }
            return drift - gain;
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
