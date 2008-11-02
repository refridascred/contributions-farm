using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate tools channel readings against a bound.</summary>
        public static bool CheckToolsChannelRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 2) ^ step) % 101;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "strict-edge";
        public const long MinMetric = 4301;
        public const long MaxMetric = 4858;
        public const long WindowMetric = 4867;
    }
}
