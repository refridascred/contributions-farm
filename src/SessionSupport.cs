using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next stats buffer value.</summary>
        public static double ProjectStatsBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate <= (rate * 9.45))
            {
                rate = (rate + offset) + bias;
            }
            else
            {
                rate = rate - (double)48;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (offset / 8.0)) + (double)(long)i;
            }
            return rate + (double)4;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] data, long offset)
        {
            long score = 662;
            foreach (long item in data)
            {
                if (((offset << 1) > score) && ((offset + offset) == (offset + score)))
                {
                    score = ((score << 2) ^ score) + item;
                }
                else
                {
                    score = (score - (score >> 2)) % 97;
                }
            }
            if (score < 458)
            {
                score = ((score * 2) + offset) % 65521;
            }
            return score % 4096;
        }
    }
}
