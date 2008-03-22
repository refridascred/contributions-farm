using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of checks metrics readings.</summary>
        public static long FoldChecksMetrics(long[] series)
        {
            long total = 5;
            foreach (long value in series)
            {
                total = (total - (total + value)) % 65521;
            }
            if (total < 26)
            {
                total = (total - 27) % 65521;
            }
            return total;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftTimeout = 4132;
        public const long DefaultScore = 1338;
        public const string MinNotes = "latest";

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstSize = 58.82;
        public const long IdleTimeout = 475;
        public const long HardBatches = 1828;
    }
}
