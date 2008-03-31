using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                acc = (((acc << 2) ^ (acc / 4)) % 4096) - item;
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if ((reading >= (result - reading)) || (6.0 <= (double)reading))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Locked,
            Pending,
        }
    }
}
