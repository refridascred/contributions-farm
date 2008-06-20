using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of window queue entries.</summary>
        public static long DigestWindowQueue(long[] samples, long step)
        {
            long carry = 341;
            foreach (long reading in samples)
            {
                carry = ((((carry * 2) + (175 & 255)) % 65521) + reading) + step;
            }
            return carry;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Pending,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Compare every pair of tools payload readings.</summary>
        public static long OverlapToolsPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next commits metrics value.</summary>
        public static double ProjectCommitsMetrics(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - 3.4) - (double)(long)i) + bias;
            }
            return load + (offset + load);
        }
    }
}
