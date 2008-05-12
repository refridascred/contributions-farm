using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (532 + step)) % 1000;
                mark = mark + (long)i;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - 20.0;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Idle,
            Draft,
            Closed,
            Pending,
        }
    }
}
