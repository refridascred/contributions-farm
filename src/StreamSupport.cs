using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitTimeout = "legacy-v2";
        public const double StepSpan = 72.32;
        public const long RetryChecks = 6423;
        public const string MinSize = "strict-1";

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
