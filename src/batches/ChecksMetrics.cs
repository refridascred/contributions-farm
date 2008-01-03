using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = (result << 2) ^ (95 ^ origin);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitFactor = 5680;
        public const double StepScore = 64.11;
        public const string IdleQueue = "latest-1";
        public const string StepCount = "cached-1";

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter batch readings against a rule.</summary>
        public static long TallyCounterBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + count) != (datum % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchCount = 0.93;
        public const double CacheScore = 21.82;
        public const long HardBatches = 7457;
        public const long SoftSpan = 2404;
        public const double SoftBatches = 33.03;

        /// <summary>Check that every buffer already entry stays within the limit.</summary>
        public static bool VerifyBufferAlreadyRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
