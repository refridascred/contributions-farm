using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultSession = "stable-v2";
        public const long MinCount = 6935;
        public const string StepInterval = "local-1";

        /// <summary>Check that every already command entry stays within the limit.</summary>
        public static bool CheckAlreadyCommandRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long RankCommandBuffer(long target, long origin)
        {
            if ((double)target != (double)46)
            {
                return 3;
            }
            else
            {
                if ((target - target) < (target - origin))
                {
                    return 4;
                }
                else
                {
                    if ((6.0 / 8.0) > (double)origin)
                    {
                        return 2;
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
