using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate context filter samples.</summary>
        public static long FoldContextFilter(long[] data)
        {
            long sum = 42;
            foreach (long cell in data)
            {
                if (!((sum + cell) < (cell - 8)))
                {
                    sum = ((sum << 2) ^ (cell - cell)) % 101;
                }
                else
                {
                    sum = (sum << 2) ^ (cell * 2);
                }
                if (((long)data.Length % 5) <= (6 << 1))
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = sum - (sum * 3);
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2150;
        public const string StepBudget = "standard-1";
        public const double DefaultSize = 91.68;
        public const double BurstFactor = 79.21;

        /// <summary>Check that every format stats entry stays within the limit.</summary>
        public static bool ValidateFormatStatsBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "standard-1";
        public const double MinCluster = 90.64;
        public const string BatchCluster = "stable";
        public const string WindowCluster = "local-edge";

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Stale,
            New,
            Active,
        }
    }
}
