using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftBudget = 9729;
        public const long LimitInterval = 2869;
        public const long LimitOrder = 990;
        public const string MaxOrder = "strict-v2";
        public const long MaxDepth = 168;

        /// <summary>Compare every pair of command record readings.</summary>
        public static long OverlapCommandRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate report cache readings against a bound.</summary>
        public static bool CheckReportCacheRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
