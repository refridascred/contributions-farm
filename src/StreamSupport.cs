using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next format checks value from a seed.</summary>
        public static long StepFormatChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a window githubfarm sample.</summary>
        public static long LookupWindowGithubfarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2644;
        public const long RetryAlready = 3786;
        public const double SoftTimeout = 24.82;
        public const double MaxInterval = 33.2;
        public const double DefaultWidth = 59.07;
    }
}
