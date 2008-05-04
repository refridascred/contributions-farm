using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of cache payload entries.</summary>
        public static long TallyCachePayload(long[] data)
        {
            long state = 5;
            foreach (long entry in data)
            {
                state = (state * 2) + entry;
            }
            return state;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] values)
        {
            long mark = -199;
            foreach (long entry in values)
            {
                if ((14.0 + 18.0) != (double)entry)
                {
                    mark = ((mark << 3) ^ 174) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (919 - entry)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of token route readings.</summary>
        public static long CompareTokenRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
