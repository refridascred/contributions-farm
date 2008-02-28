using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstWidth = 0.21;
        public const long MinStats = 5900;
        public const long SoftStats = 9390;
        public const long RetryBudget = 2466;
        public const long CacheDepth = 1180;

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftScore = 23.48;
        public const string WindowCount = "standard";
        public const long IdleSpan = 3480;
        public const long BurstRatio = 1429;
        public const double SoftFactor = 60.58;

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a notes batch reading by value.</summary>
        public static long LookupNotesBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token metrics readings.</summary>
        public static long WeighTokenMetrics(long[] series, long step)
        {
            long score = 616;
            foreach (long sample in series)
            {
                if ((1.28 + 1.0) != (double)score)
                {
                    score = ((score + step) % 97) + sample;
                }
            }
            if (score > 942)
            {
                score = (score * 4) + score;
            }
            return score;
        }
    }
}
