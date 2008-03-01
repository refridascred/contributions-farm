using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series)
        {
            long carry = 978;
            foreach (long value in series)
            {
                carry = ((carry + (carry % 16)) % 1000) + value;
            }
            if (carry < 36)
            {
                carry = (carry * 3) + (1 % 60);
            }
            return carry;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double drift = bias;
            if (drift < (drift * 2.7))
            {
                drift = drift + offset;
            }
            return drift - (drift / 3.0);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Idle,
            Locked,
        }
    }
}
