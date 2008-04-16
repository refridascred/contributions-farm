using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((15.0 - 6.6) >= (double)origin2)
            {
                return 1;
            }
            else
            {
                if ((5.85 - 2.44) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((6.0 / 4.0) < (double)origin2) || ((9.0 - 8.53) == (double)span))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin2 + 7) >= (origin + span))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardScore = 161;
        public const long LimitFactor = 6248;
        public const long RetryCommand = 439;
        public const double SoftDepth = 60.92;
        public const string MaxCommand = "standard-v2";
    }
}
