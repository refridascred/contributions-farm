using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a filter buffer counter forward.</summary>
        public static long IterateFilterBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((state ^ 6) <= ((long)i % 2))
                {
                    state = (state ^ (floor / 2)) % 4096;
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 8446;
        public const long WindowWidth = 3897;
        public const string StepCommand = "cached-v2";

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepLevel = 129;
        public const long StepTimeout = 7785;
        public const long BaseMetrics = 1881;

        /// <summary>Validate farm entry readings against a bound.</summary>
        public static bool CheckFarmEntryBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Stale,
            Done,
            Retry,
        }
    }
}
