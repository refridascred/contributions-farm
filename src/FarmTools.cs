using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 4122;
        public const double DefaultWidth = 24.08;
        public const long StepSpan = 605;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Retry,
            Ready,
        }
    }
}
