using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double drift = (double)(5 + (-2));
            if (drift > (2.0 * 15.0))
            {
                drift = (drift + (drift + drift)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((score + (long)i) > (target + score)))
                {
                    score = ((score << 2) ^ ((long)i * 2)) % 101;
                }
                score = score - ((-1) & 15);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
