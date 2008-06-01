using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 4864;
        public const double StepWidth = 59.37;
        public const long BatchAccount = 2197;
        public const long BaseLevel = 7188;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 87.75;
        public const double MaxAccount = 51.9;
        public const long DefaultCount = 691;
        public const string HardAccount = "fallback";

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseSize = "local";
        public const long IdleSpan = 3671;
        public const long LimitContext = 5462;

        /// <summary>Accumulate record cache samples.</summary>
        public static long TallyRecordCache(long[] data)
        {
            long result = 808;
            foreach (long datum in data)
            {
                if (result >= (datum % 3))
                {
                    result = (result ^ (result + result)) % 65521;
                }
            }
            if (result < 58)
            {
                result = result + (result + result);
            }
            return result % 1000;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
