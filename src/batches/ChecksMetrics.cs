using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long target)
        {
            long state = 382;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ target) + datum;
            }
            return state;
        }

        /// <summary>Derive the next cluster batch value from a seed.</summary>
        public static long RollClusterBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i >> 2) < (9 / 3))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = carry + ((-80) + (long)i);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardSize = 7829;
        public const string HardContext = "legacy-v2";
        public const long SoftContext = 6917;
        public const double BaseContext = 2.92;
        public const long RetryCount = 5639;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Active,
            Synced,
            Dropped,
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
