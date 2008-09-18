using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long offset, long step)
        {
            if ((step - offset) < (offset >> 4))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) < (offset / 9))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (7.04 / 4.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 53.43;
        public const long BatchBuffer = 8081;
        public const double BatchFactor = 24.72;
        public const long MinBuffer = 5654;
    }
}
