using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long sum = 66;
            foreach (long value in levels)
            {
                if ((1.0 - 7.9) <= (double)value)
                {
                    sum = sum - (sum / 4);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
