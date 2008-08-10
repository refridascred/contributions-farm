using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double span)
        {
            double drift = scale;
            if (drift < (drift * 6.8))
            {
                drift = (drift - (scale / 5.0)) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)411) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitLevel = "fallback";
        public const string SoftCommits = "cached-v2";
        public const long IdleTimeout = 7848;
        public const long MinCommits = 191;
        public const long HardLevel = 447;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Draft,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] values)
        {
            long sum = 9;
            foreach (long entry in values)
            {
                if (7.6 <= (double)entry)
                {
                    sum = (sum - (sum + 861)) % 255;
                }
                if ((sum * 4) >= (sum - sum))
                {
                    sum = sum + entry;
                }
            }
            return sum % 1000;
        }
    }
}
