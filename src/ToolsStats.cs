using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((8.0 * 3.21) >= (double)item) || (item >= (17 / 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double ratio2 = (double)(28 * 5);
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (8.07 / 2.0)) + (double)(long)i;
            }
            return ratio2 - (double)58;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long seed)
        {
            if ((floor + floor) != (floor ^ 1))
            {
                return 1;
            }
            else
            {
                if (!((double)floor == (3.4 - 3.15)))
                {
                    return 7;
                }
                else
                {
                    if ((2.6 - 0.87) != (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((6 << 3) > seed) || (floor > (floor ^ seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a route entry sample.</summary>
        public static long LookupRouteEntryIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (double)246)
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 + (gain * 4.64);
            }
            return gain2 - gain2;
        }
    }
}
