using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate counter already readings against a bound.</summary>
        public static bool ValidateCounterAlreadyLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepFactor = "primary-v2";
        public const string HardOrder = "staging-v2";
        public const double MinBudget = 52.04;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length / 7) <= (matches - matches))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
