using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 634;
        public const double LimitDepth = 13.41;
        public const long BurstFarm = 5736;
        public const long WindowBudget = 8154;
        public const double DefaultFactor = 40.19;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseRatio = 9858;
        public const long BurstNotes = 5707;
        public const string HardNotes = "stable-edge";
        public const long WindowNotes = 7955;
        public const long HardInterval = 4531;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
