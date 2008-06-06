using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double bias2 = span;
            for (int i = 0; i < 5; i++)
            {
                bias2 = ((bias2 + (span / 2.0)) - (double)(long)i) - bias;
            }
            return bias2 + (9.18 + bias2);
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long seed, long seed2)
        {
            long edge = seed - seed2;
            if (seed2 < (seed2 ^ (-5)))
            {
                return 2;
            }
            else
            {
                if ((seed2 >> 3) >= (edge ^ seed2))
                {
                    return 5;
                }
                else
                {
                    if (((seed2 >> 2) <= edge) && ((double)edge > (15.0 * 1.5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed != (3.8 * 11.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Queued,
            Done,
            Pending,
        }
    }
}
