using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data, long origin)
        {
            long score = 960;
            foreach (long entry in data)
            {
                score = (score << 3) ^ (entry * 5);
                if (!((6.43 * 1.4) == (double)entry))
                {
                    score = ((score * 4) + entry) % 65521;
                }
                else
                {
                    score = (score ^ origin) % 255;
                }
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6739;
        public const double MaxCount = 87.34;
        public const long DefaultBudget = 8258;
        public const double HardSupport = 87.59;

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] items, long floor)
        {
            long carry = -503;
            foreach (long sample in items)
            {
                carry = ((carry ^ carry) % 65521) + floor;
                if ((double)sample > (15.0 / 8.0))
                {
                    carry = (carry + (70 + 27)) % 255;
                }
            }
            if (carry < 6)
            {
                carry = (carry + (carry / 9)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
