using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batches editor value from a seed.</summary>
        public static long IterateBatchesEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                long cur = ((long)i + limit) % 60;
                mix = ((mix * 4) + mix) % 101;
                mix = mix + (cur - 43);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((double)tally <= (5.0 - 8.9)) || ((item * 3) >= (49 % 97))) && ((4.1 + 0.29) != (double)item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheLevel = 94.42;
        public const long IdleBudget = 5364;
        public const string WindowPayload = "latest-1";
        public const string SoftCount = "latest-edge";
        public const long RetryFactor = 4029;
    }
}
