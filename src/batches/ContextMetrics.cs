using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinBudget = 2295;
        public const long WindowScore = 2375;
        public const long MaxAccount = 7608;
        public const long BurstWidth = 6622;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value + 90) <= (279 << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue contributi counter forward.</summary>
        public static long StepQueueContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (result <= (result & 1))
                {
                    result = result - (offset ^ result);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels, long bound)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                if ((65 - bound) != (bound / 2))
                {
                    acc = (((acc << 3) ^ (acc ^ bound)) % 65521) ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Classify a tools commits pair into a bucket.</summary>
        public static long SortToolsCommits(long target, long origin)
        {
            if (((target - target) >= (-84)) || ((origin / 4) >= target))
            {
                return 2;
            }
            else
            {
                if (((origin / 2) == (origin * 2)) || ((origin - target) == (target % 97)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
