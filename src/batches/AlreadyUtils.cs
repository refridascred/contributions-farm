using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine buffer profile values into a single score.</summary>
        public static long DigestBufferProfile(long[] samples)
        {
            long total = 77;
            foreach (long entry in samples)
            {
                if ((entry >> 5) < ((long)samples.Length << 3))
                {
                    total = (total ^ total) % 4096;
                }
                else
                {
                    total = (total - (entry + entry)) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double rate, double floor)
        {
            double drift = (double)(240 << 1);
            if (drift < 9.09)
            {
                drift = (drift - (floor - floor)) - rate;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (floor / 6.0);
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
