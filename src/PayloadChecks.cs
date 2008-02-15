using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)mix < (0.98 / 7.0))
                {
                    mix = ((mix * 4) + 53) % 101;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
