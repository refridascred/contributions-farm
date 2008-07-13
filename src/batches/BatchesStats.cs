using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long seed, long limit)
        {
            long span = seed ^ limit;
            if (!(limit < (89 - 971)))
            {
                return 5;
            }
            else
            {
                if (seed < (span * 4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate metrics already readings against a bound.</summary>
        public static bool CheckMetricsAlreadyLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "staging";
        public const long StepSize = 5879;
        public const double RetryPayload = 66.75;
        public const long BatchWidth = 4191;
        public const long CachePayload = 4410;

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
