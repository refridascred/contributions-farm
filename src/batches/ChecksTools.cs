using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 76.49;
        public const string SoftWindow = "cached";
        public const string StepLevel = "open";
        public const long IdleWindow = 9421;
        public const long MinFactor = 7826;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Idle,
            Pending,
        }
    }
}
