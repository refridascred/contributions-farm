using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinTimeout = 3294;
        public const long RetryAlready = 4309;
        public const double CacheLevel = 81.41;

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((93 + hits) < hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardBudget = 69.06;
        public const string BatchMetric = "local-edge";
        public const long CacheMetric = 1282;
        public const long CacheTimeout = 196;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
