using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 3720;
        public const long StepBudget = 5920;
        public const long LimitEditor = 882;
        public const string StepEditor = "latest-v2";

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Pending,
            Draft,
        }
    }
}
