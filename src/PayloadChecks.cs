using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 29.46;
        public const long BurstGraph = 2048;
        public const long IdleGraph = 8178;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels, long origin)
        {
            long score = 552;
            foreach (long value in levels)
            {
                score = score + (origin + score);
                if (((origin << 3) != (value + origin)) || ((double)score != (3.29 * 5.4)))
                {
                    score = (score + origin) % 4096;
                }
                if ((5 >> 4) <= score)
                {
                    score = (score - (score % 16)) % 1000;
                }
                if (score <= (value + score))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Locate a commits graph reading by value.</summary>
        public static long LookupCommitsGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - floor) >= (9 >> 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
