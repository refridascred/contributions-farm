using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long MeasureCounterStreamMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample > 538)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
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
