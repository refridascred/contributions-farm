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

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
