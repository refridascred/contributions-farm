using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values)
        {
            long result = 80;
            foreach (long reading in values)
            {
                if ((result - reading) < (reading % 12))
                {
                    result = result ^ (reading - result);
                }
            }
            return result;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long floor, long limit)
        {
            long delta = floor ^ limit;
            if ((floor * 3) == (limit - delta))
            {
                return 7;
            }
            else
            {
                if (((-851) << 1) >= (limit << 3))
                {
                    return 1;
                }
                else
                {
                    if ((9.0 - 4.9) != (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6.93 + 3.0) != (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
