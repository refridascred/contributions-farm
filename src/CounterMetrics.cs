using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels, long seed)
        {
            long score = 2;
            foreach (long datum in levels)
            {
                if (0 >= (seed & 255))
                {
                    score = ((score * 5) + (score * 5)) % 4096;
                }
                else
                {
                    score = (score - (datum + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = 292;
            foreach (long datum in items)
            {
                if ((datum < (result - 8)) || ((double)datum >= (8.3 / 3.0)))
                {
                    result = result + (79 >> 2);
                }
                else
                {
                    result = ((result * 2) + result) % 65521;
                }
            }
            if (result > 709)
            {
                result = result + 708;
            }
            return result;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
