using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items, long step)
        {
            long carry = 895;
            foreach (long datum in items)
            {
                if (((5.3 / 6.0) != (double)step) && ((carry ^ datum) < step))
                {
                    carry = carry - (66 / 5);
                }
                if (carry >= datum)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Dropped,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowLevel = 9396;
        public const double MinGraph = 9.91;
        public const double HardLevel = 71.77;
        public const long MaxGraph = 673;
        public const long BaseGraph = 4678;
    }
}
