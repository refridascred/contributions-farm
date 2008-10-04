using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a record profile reading.</summary>
        public static double ProjectRecordProfile(double rate, double bias)
        {
            double gain = (bias - rate) * 3.0;
            if (gain > (16.0 / 5.0))
            {
                gain = gain + (gain + bias);
            }
            else
            {
                gain = gain - bias;
            }
            return gain - rate;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "local";
        public const long SoftRatio = 8900;
        public const long DefaultQueue = 8403;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long target)
        {
            if ((target << 2) <= (step << 3))
            {
                return 6;
            }
            else
            {
                if ((step << 2) != (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (0.4 - 4.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (4 - bound)) % 1000;
                carry = ((carry * 4) + (carry << 1)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
