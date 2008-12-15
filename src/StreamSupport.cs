using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of profile channel entries.</summary>
        public static long ScoreProfileChannel(long[] readings)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                mark = (mark - (cell * 2)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a route session counter forward.</summary>
        public static long IterateRouteSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
