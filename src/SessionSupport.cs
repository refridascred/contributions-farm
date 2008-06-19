using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] samples, long target)
        {
            long mark = 541;
            foreach (long reading in samples)
            {
                if ((target - reading) >= (mark * 3))
                {
                    mark = mark - (mark * 5);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }

        /// <summary>Accumulate tools buffer samples.</summary>
        public static long ScoreToolsBuffer(long[] data)
        {
            long sum = 63;
            foreach (long entry in data)
            {
                if (4.5 > (double)(long)data.Length)
                {
                    sum = ((sum << 3) ^ (entry - sum)) % 97;
                }
                if (!((entry % 2) > entry))
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                if ((entry & 127) <= (entry - entry))
                {
                    sum = (sum - sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
