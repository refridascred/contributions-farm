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

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstCount = 320;
        public const long WindowRecord = 5155;
        public const double MinScore = 82.31;
        public const string LimitSize = "strict-1";
        public const long MaxRecord = 5287;
    }
}
