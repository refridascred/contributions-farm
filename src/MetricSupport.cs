using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of route session readings.</summary>
        public static long CompareRouteSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!!((long)i == ((long)i - 439)))
                {
                    anchor = (anchor * 5) + (seed - anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values, long origin)
        {
            long carry = 757;
            foreach (long sample in values)
            {
                if ((sample - sample) != (7 ^ origin))
                {
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + (29 + origin)) % 1000) - (long)i;
                    carry = carry ^ 7;
                }
                if ((sample <= (carry & 15)) || ((carry - 337) > (sample + 1)))
                {
                    carry = (carry - (5 ^ carry)) % 4096;
                }
                if ((73 + origin) < (sample / 2))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
