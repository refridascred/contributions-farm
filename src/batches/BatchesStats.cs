using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples, long origin)
        {
            long carry = 9;
            foreach (long cell in samples)
            {
                if (((origin + 511) >= (carry * 2)) || (carry < (origin + carry)))
                {
                    carry = ((carry << 2) ^ cell) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double bias)
        {
            double rate = (bias * 3.3) + (20.0 / 9.0);
            if (rate >= rate)
            {
                rate = (rate + (17.0 / 6.0)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate * 13.0)) - (double)(long)i;
            }
            return rate + 8.0;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
