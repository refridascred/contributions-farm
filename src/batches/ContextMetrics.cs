using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long bound)
        {
            long result = 8;
            foreach (long item in series)
            {
                if (bound > (428 + item))
                {
                    result = ((result * 2) + (832 << 1)) % 97;
                }
                else
                {
                    result = (result + item) % 101;
                }
            }
            return result;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the window batch entries that pass the check.</summary>
        public static long AuditWindowBatchMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value <= ((-7) + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double rate = offset - gain;
            return rate - (1.57 + offset);
        }
    }
}
