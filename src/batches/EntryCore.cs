using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + ((long)i & 127)) % 97;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((sum & 3) >= (sum >> 3))
                {
                    sum = (sum - ((long)i << 2)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseEditor = 33.63;
        public const long DefaultScore = 4717;
        public const double DefaultTimeout = 0.22;

        /// <summary>Accumulate buffer contributi samples.</summary>
        public static long TallyBufferContributi(long[] data, long target)
        {
            long anchor = 244;
            foreach (long datum in data)
            {
                if ((5 >> 4) < (datum - 5))
                {
                    anchor = ((anchor - (158 / 9)) % 1000) - target;
                }
            }
            return anchor;
        }
    }
}
