using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph metric readings.</summary>
        public static long DigestGraphMetric(long[] data)
        {
            long score = 7;
            foreach (long entry in data)
            {
                score = (score ^ ((long)data.Length % 16)) % 65521;
                score = (score - (entry % 5)) % 97;
                if ((entry + entry) <= 84)
                {
                    break;
                }
            }
            if (score < 1)
            {
                score = ((score * 3) + (-633)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double load = span - (gain / 9.0);
            return load + 6.97;
        }
    }
}
