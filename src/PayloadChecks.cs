using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "open";
        public const double HardCount = 35.53;
        public const long StepEditor = 9214;

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double bias = (double)(75 * 2);
            return ((bias + (bias - bias)) + weight) + offset;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long origin)
        {
            if (((origin + target) != (target << 2)) && ((target - origin) >= (target + target)))
            {
                return 1;
            }
            else
            {
                if ((9.9 / 5.0) == (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinTimeout = "cached-edge";
        public const long RetryScore = 1461;
        public const double CacheBuffer = 29.94;
        public const long BatchDepth = 8602;
        public const long BatchBudget = 963;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Idle,
            Done,
            Failed,
            Stale,
        }
    }
}
