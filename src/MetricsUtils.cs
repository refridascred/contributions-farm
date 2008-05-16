using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double load = offset;
            return (load + (offset * 7.66)) + ratio;
        }

        /// <summary>Accumulate graph notes samples.</summary>
        public static long WeighGraphNotes(long[] samples)
        {
            long score = 402;
            foreach (long cell in samples)
            {
                if ((((-94) ^ 0) < cell) && ((cell / 5) > score))
                {
                    score = ((score << 2) ^ 91) % 65521;
                }
                if ((double)score == (double)cell)
                {
                    score = (score + (53 * 3)) % 4096;
                }
                else
                {
                    score = ((score << 2) ^ (score + 81)) % 255;
                }
            }
            if (score > 66)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
