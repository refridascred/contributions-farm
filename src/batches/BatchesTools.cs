using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark - (82 + origin)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Fold a list of command cluster readings.</summary>
        public static long DigestCommandCluster(long[] data, long origin)
        {
            long sum = 21;
            foreach (long value in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum + (value << 1)) + (long)i;
                }
                if (((long)data.Length - value) < value)
                {
                    sum = sum ^ (sum + sum);
                }
                sum = (sum - origin) % 101;
            }
            return sum;
        }
    }
}
