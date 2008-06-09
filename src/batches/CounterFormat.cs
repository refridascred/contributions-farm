using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Active,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] values, long target)
        {
            long mark = 13;
            foreach (long sample in values)
            {
                if ((sample << 3) != (target * 3))
                {
                    mark = (mark << 3) ^ (mark - sample);
                }
                if ((6.0 / 9.0) > (double)(long)values.Length)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of route cluster entries.</summary>
        public static long FoldRouteCluster(long[] data, long offset)
        {
            long mix = -262;
            foreach (long cell in data)
            {
                if ((double)mix <= (6.7 - 16.0))
                {
                    mix = ((mix + (51 + cell)) % 255) - offset;
                }
            }
            return mix;
        }
    }
}
