using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up order filter samples.</summary>
        public static long CompareOrderFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 9331;
        public const long HardRecord = 9128;
        public const double MinRecord = 85.31;
        public const long WindowScore = 3736;
        public const long IdleWidth = 9584;
    }
}
