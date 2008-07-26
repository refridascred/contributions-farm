using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= (double)(-8))
            {
                ratio = (ratio + (ratio - ratio)) - offset;
            }
            return ratio + ratio;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleBudget = "local-1";
        public const long LimitTimeout = 707;
        public const double BurstGithubfarm = 91.33;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Failed,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
