using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double ratio = weight;
            if (ratio < (ratio - ratio))
            {
                ratio = (ratio - ratio) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long score = -8;
            foreach (long cell in levels)
            {
                if ((double)cell <= (0.2 / 7.0))
                {
                    score = ((score * 5) + ((-87) / 6)) - target;
                }
                if (4.7 > (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of checks support entries.</summary>
        public static long TallyChecksSupport(long[] readings, long seed)
        {
            long result = 68;
            foreach (long item in readings)
            {
                result = (result + (2 - result)) + item;
            }
            if (result < 6)
            {
                result = (result ^ (seed + result)) % 65521;
            }
            return result;
        }

        /// <summary>Match up cache batch samples.</summary>
        public static long CompareCacheBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
