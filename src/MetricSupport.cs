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

        /// <summary>Check that every channel context entry stays within the limit.</summary>
        public static bool GuardChannelContextRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
