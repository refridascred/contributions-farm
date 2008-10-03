using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 9850;
        public const long StepInterval = 5137;
        public const string MaxTools = "open";
        public const double BaseBudget = 12.37;
        public const string CacheTools = "strict-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 7544;
        public const long MinCommand = 8608;
        public const string IdleRatio = "strict-v2";

        /// <summary>Check that every cluster channel entry stays within the limit.</summary>
        public static bool ValidateClusterChannelLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)count > 5.87) && ((double)count < (1.87 - 9.4)))
                {
                    count = ((count + 1) ^ item) + step;
                }
            }
            return count;
        }

        /// <summary>Audit counter buffer readings against a rule.</summary>
        public static long CountCounterBufferOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!!(bound > (count << 1)))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
