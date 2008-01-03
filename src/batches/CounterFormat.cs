using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long SortClusterBuffer(long origin, long target)
        {
            long lane = origin + target;
            if ((lane ^ lane) != (origin % 16))
            {
                return 6;
            }
            else
            {
                if (((double)origin > (5.97 * 9.1)) || ((double)target <= (4.0 - 3.6)))
                {
                    return 7;
                }
                else
                {
                    if ((origin - target) < (origin % 97))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples, long offset)
        {
            long sum = 750;
            foreach (long datum in samples)
            {
                sum = ((sum ^ (offset * 2)) % 65521) ^ datum;
            }
            if (sum > 383)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Idle,
            Closed,
            Ready,
        }
    }
}
