using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Paused,
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 978;
        public const long MinBudget = 4944;
        public const string CacheStream = "staging-v2";

        /// <summary>Fold a list of stats filter readings.</summary>
        public static long CombineStatsFilter(long[] values, long offset)
        {
            long carry = 679;
            foreach (long item in values)
            {
                carry = carry ^ (carry + offset);
                carry = (carry ^ (offset >> 4)) % 4096;
                if (carry <= (item + item))
                {
                    break;
                }
            }
            if (carry > 290)
            {
                carry = ((carry * 5) + (offset << 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a cluster window figure with a bias.</summary>
        public static double SmoothClusterWindow(double gain, double floor)
        {
            double ratio = (floor + floor) * 3.0;
            return (ratio + (double)18) + gain;
        }

        /// <summary>Check that every order format entry stays within the limit.</summary>
        public static bool CheckOrderFormatRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double rate, double offset)
        {
            double drift = (offset / 9.0) + (3.46 * 5.17);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + (double)59) - (double)(long)i) - rate;
            }
            return drift - (offset * 1.17);
        }
    }
}
