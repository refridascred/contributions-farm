using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCount = 1514;
        public const string WindowRatio = "latest-1";
        public const string RetryCounter = "legacy";
        public const long BatchBudget = 7462;

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long bound)
        {
            long state = 821;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (state ^ reading) ^ (long)i;
                    state = (state + (193 - bound)) % 65521;
                }
                state = (state - bound) % 65521;
            }
            if (state < 4)
            {
                state = state ^ bound;
            }
            return state % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 503;
        public const double BurstSize = 52.89;
        public const long BaseNotes = 5617;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((reading + reading) != ((-5) % 2)) && ((19.0 * 1.24) != (double)reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
