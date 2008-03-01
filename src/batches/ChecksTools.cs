using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 2) + (2 * 4);
                total = ((total << 2) ^ (target * 5)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 72.15;
        public const long LimitMetric = 797;
        public const long StepLevel = 2768;

        /// <summary>Combine support cluster values into a single score.</summary>
        public static long CombineSupportCluster(long[] items, long seed)
        {
            long acc = 0;
            foreach (long reading in items)
            {
                acc = (((acc - (acc * 2)) % 97) ^ reading) - seed;
            }
            return acc % 4096;
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long TallyBatchEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally > (tally ^ entry)) && (((78 & 255) != (32 ^ tally)) && ((entry - tally) > (tally & 127))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
