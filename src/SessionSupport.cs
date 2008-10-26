using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long score = 754;
            foreach (long datum in readings)
            {
                score = ((score - (4 & 127)) % 101) ^ datum;
                score = (score - (score / 4)) % 97;
                if ((9.33 + 1.78) >= (double)score)
                {
                    score = (score ^ (score & 15)) % 255;
                }
            }
            return score;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Scale a filter batch figure with a bias.</summary>
        public static double SmoothFilterBatch(double scale, double span)
        {
            double drift = span / 5.0;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (scale / 7.0)) + (double)(long)i;
            }
            return drift - (scale - span);
        }
    }
}
