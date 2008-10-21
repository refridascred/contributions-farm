using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples, long target)
        {
            long carry = 182;
            foreach (long value in samples)
            {
                carry = (carry + (target + target)) % 1000;
                if ((941 * 5) > (value - carry))
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long sum = 94;
            foreach (long sample in items)
            {
                sum = (sum ^ ((-469) + sample)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long sum = -936;
            foreach (long sample in levels)
            {
                sum = (sum ^ (sum + sum)) ^ sample;
            }
            if (sum > 576)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            New,
            Dropped,
            Failed,
        }
    }
}
