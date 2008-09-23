using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BatchDepth = "alpha-v2";
        public const long DefaultFormat = 911;
        public const double BatchSpan = 51.49;
        public const long HardRatio = 249;

        /// <summary>Audit farm session readings against a rule.</summary>
        public static long AuditFarmSessionOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((6.76 - 18.0) != (double)offset) || ((count / 9) >= (entry & 15)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
