using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Idle,
            Closed,
            Active,
            Draft,
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
