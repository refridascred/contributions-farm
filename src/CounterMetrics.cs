using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up window token samples.</summary>
        public static long MatchWindowTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBatch = 52.55;
        public const string BaseBatch = "cached-1";
        public const long SoftBatch = 5401;
        public const string RetryBatch = "standard-1";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen % 24) < (seen - seen))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
