using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long step)
        {
            long span = bound - step;
            if (987 < bound)
            {
                return 0;
            }
            else
            {
                if ((double)step != (double)span)
                {
                    return 1;
                }
                else
                {
                    if (((step + step) < bound) || ((step / 3) == (step ^ span)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            New,
            Ready,
        }

        /// <summary>Check that every tools editor entry stays within the limit.</summary>
        public static bool ValidateToolsEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 81.94;
        public const long WindowMetric = 4611;
        public const long HardBudget = 1277;
        public const double DefaultMetric = 24.41;
        public const double DefaultCount = 87.98;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Pending,
            New,
            Draft,
            Retry,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits + 45) > (hits * 2))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
