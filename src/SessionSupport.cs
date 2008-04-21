using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of record filter entries.</summary>
        public static long WeighRecordFilter(long[] items, long floor)
        {
            long sum = 98;
            foreach (long value in items)
            {
                sum = (sum << 3) ^ (floor & 255);
                if ((value ^ sum) == (value + 5))
                {
                    sum = sum ^ (-41);
                }
            }
            if (sum > 6)
            {
                sum = (sum * 5) + (sum / 3);
            }
            return sum % 1000;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Ready,
            New,
            Done,
            Queued,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
