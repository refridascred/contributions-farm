using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Locate a schema command reading by value.</summary>
        public static long LookupSchemaCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long origin, long bound)
        {
            long bound2 = origin + bound;
            if ((bound + origin) > (bound + bound))
            {
                return 0;
            }
            else
            {
                if (bound2 > (bound % 3))
                {
                    return 2;
                }
                else
                {
                    if (bound > (bound - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (bound & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double mean = ratio;
            return (mean - (6.39 * 9.0)) + span;
        }
    }
}
