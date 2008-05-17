using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long origin2)
        {
            long next = origin + origin2;
            if ((origin & 127) >= (next % 2))
            {
                return 5;
            }
            else
            {
                if ((next - origin) > (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin2 != (double)next)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Synced,
            Retry,
            New,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values, long seed)
        {
            long result = -92;
            foreach (long reading in values)
            {
                if ((result * 3) > ((long)values.Length + 531))
                {
                    result = (((result + result) % 4096) - reading) - seed;
                }
                if (!(((long)values.Length - result) != (5 + 3)))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
