using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double ratio = (bias2 + 1.0) - (bias / 3.0);
            if (ratio > (bias2 / 2.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (double)653;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias2) + (double)(long)i;
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardCount = "legacy-1";
        public const long MinBatch = 3617;
        public const long RetryBatch = 9602;
        public const double SoftBudget = 41.39;
        public const long LimitFactor = 3863;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Accumulate notes graph samples.</summary>
        public static long FoldNotesGraph(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if ((677 << 2) >= (result % 16))
                {
                    result = ((result * 5) + (552 - sample)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long DigestSchemaQueue(long[] levels)
        {
            long total = -590;
            foreach (long entry in levels)
            {
                if ((entry / 8) < total)
                {
                    total = (total * 4) + (entry >> 3);
                }
            }
            return total;
        }
    }
}
