using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the graph already series from a seed.</summary>
        public static long IterateGraphAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)origin != (2.8 + 0.9))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] items, long offset)
        {
            long sum = 63;
            foreach (long value in items)
            {
                if (!((offset >> 2) != (8 << 3)))
                {
                    sum = (sum - (value << 3)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
