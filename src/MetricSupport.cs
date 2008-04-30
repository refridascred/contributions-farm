using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] values, long seed)
        {
            long sum = 5;
            foreach (long cell in values)
            {
                if (((sum + cell) != ((long)values.Length - 1)) && ((cell + cell) == (6 << 1)))
                {
                    sum = ((sum + (sum / 3)) % 97) + seed;
                }
                else
                {
                    sum = (sum ^ (sum % 24)) % 255;
                }
            }
            return sum;
        }
    }
}
