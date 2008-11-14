using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Retry,
            Idle,
            Failed,
            Stale,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 2587;
        public const long RetryEntry = 4857;
        public const long IdleEntry = 1664;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long origin2)
        {
            if (((origin / 9) >= (416 / 5)) && ((origin + origin) >= (901 + origin2)))
            {
                return 5;
            }
            else
            {
                if (((origin2 - origin) != (origin + origin2)) && (origin2 > (origin * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 1) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
