using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Done,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double gain, double span)
        {
            double load = (double)365;
            if (load <= (span + 13.0))
            {
                load = load + load;
            }
            else
            {
                load = load + 3.8;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (gain + gain)) - (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Digest a series of batches filter entries.</summary>
        public static long WeighBatchesFilter(long[] series)
        {
            long result = -5;
            foreach (long cell in series)
            {
                if (!((double)cell < 4.3))
                {
                    result = (result - result) % 65521;
                }
                if ((double)result >= (7.24 * 13.0))
                {
                    result = (result ^ (cell - 1)) % 101;
                }
                else
                {
                    result = result + result;
                }
                result = result - (cell & 31);
            }
            return result;
        }
    }
}
