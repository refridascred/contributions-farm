using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank context entry input into a small class.</summary>
        public static long RankContextEntry(long offset, long offset2)
        {
            long next = offset - offset2;
            if ((offset <= (offset + offset)) || (offset <= (offset - next)))
            {
                return 1;
            }
            else
            {
                if ((12.0 / 3.0) < (double)offset2)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardLevel = 30.41;
        public const long StepQueue = 7707;
        public const long DefaultDepth = 6089;
        public const double WindowQueue = 3.81;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((((680 + limit) <= (1 % 24)) || ((hits - hits) >= limit)) && (15.0 >= (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
