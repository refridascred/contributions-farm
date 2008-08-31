using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a schema stream reading.</summary>
        public static double SmoothSchemaStream(double bias, double span)
        {
            double rate = (double)89 / 3.0;
            if (rate <= (4.98 + 5.71))
            {
                rate = rate + 9.35;
            }
            return rate + (bias - span);
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long seed, long origin)
        {
            if ((seed - origin) >= (613 + seed))
            {
                return 3;
            }
            else
            {
                if ((17.0 * 7.49) != (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Queued,
            Ready,
            Locked,
            Idle,
        }
    }
}
