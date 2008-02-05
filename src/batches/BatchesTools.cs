using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((double)state < (double)offset)
                {
                    state = (state - offset) % 65521;
                    break;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
