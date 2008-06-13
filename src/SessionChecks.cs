using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank editor session input into a small class.</summary>
        public static long RankEditorSession(long target, long bound)
        {
            if ((bound << 1) >= (2 << 2))
            {
                return 5;
            }
            else
            {
                if ((double)target != (6.18 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound <= (double)27)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up notes schema samples.</summary>
        public static long PairNotesSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 8473;
        public const string StepCommits = "strict-1";
        public const double RetryTimeout = 62.72;
        public const long WindowInterval = 7397;
        public const double BatchCommits = 12.96;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] levels)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                if (((7.62 - 3.02) != (double)value) || ((acc - value) > acc))
                {
                    acc = ((acc << 2) ^ (value * 5)) % 101;
                }
            }
            if (acc > 3)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }
    }
}
