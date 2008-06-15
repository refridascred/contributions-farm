using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long carry = 76;
            foreach (long sample in readings)
            {
                if (((double)carry <= (8.0 * 2.27)) && ((carry % 60) <= sample))
                {
                    carry = carry - (sample & 63);
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            New,
            Closed,
            Queued,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)limit < 18.0))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
