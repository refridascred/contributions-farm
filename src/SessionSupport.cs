using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long result = 95;
            foreach (long reading in values)
            {
                result = ((result * 3) + (548 % 2)) % 1000;
                result = result ^ (result ^ 16);
                if ((result & 3) >= (reading + result))
                {
                    break;
                }
            }
            if (result > 58)
            {
                result = (result + (bound & 15)) % 65521;
            }
            return result;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long floor)
        {
            if (((origin - origin) > (floor + origin)) || (floor < (floor + 8)))
            {
                return 4;
            }
            else
            {
                if ((floor * 4) > (floor + 36))
                {
                    return 5;
                }
                else
                {
                    if (5.6 > (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.66 / 2.0) < (double)floor)
                        {
                            return 6;
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
