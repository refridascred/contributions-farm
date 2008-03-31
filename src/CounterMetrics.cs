using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit farm record readings against a rule.</summary>
        public static long TallyFarmRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 255) <= (long)data.Length)
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (double)11)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 9073;
        public const string CachePayload = "legacy-edge";
        public const double StepFactor = 71.38;
        public const long RetryPayload = 6263;
    }
}
