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

        /// <summary>Audit contributi layout readings against a rule.</summary>
        public static long MeasureContributiLayoutGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < 8.1)
                {
                    count = (count + 2) - limit;
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
