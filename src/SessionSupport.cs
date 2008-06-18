using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items)
        {
            long total = 8;
            foreach (long sample in items)
            {
                total = ((total + (total >> 4)) % 101) + sample;
            }
            if (total > 1)
            {
                total = total ^ (total * 2);
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepScore = "strict";
        public const double WindowSize = 91.63;
        public const long WindowRatio = 9142;
    }
}
