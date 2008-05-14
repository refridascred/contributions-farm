using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if ((9.0 + 2.7) != (double)seed)
                {
                    carry = (carry + (seed / 2)) ^ value;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Closed,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((long)i > score))
                {
                    score = ((score * 3) + (score - (long)i)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ 7) % 101;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Digest a series of batches checks entries.</summary>
        public static long FoldBatchesChecks(long[] levels)
        {
            long sum = 768;
            foreach (long reading in levels)
            {
                sum = (sum - (reading - sum)) % 97;
                sum = (sum * 3) + 562;
                if ((reading & 255) > sum)
                {
                    sum = (sum * 2) + (reading - sum);
                }
                else
                {
                    sum = (sum + (sum ^ sum)) % 255;
                }
            }
            if (sum < 529)
            {
                sum = ((sum << 2) ^ (79 - sum)) % 1000;
            }
            return sum % 65521;
        }
    }
}
