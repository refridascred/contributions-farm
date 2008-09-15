using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the farm format series from a seed.</summary>
        public static long DeriveFarmFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total << 3) ^ (origin << 2);
                total = (total + total) % 101;
                if (((total / 3) == (origin << 1)) || ((total << 3) < origin))
                {
                    total = total ^ total;
                    total = (total << 2) ^ (total & 255);
                }
                else
                {
                    total = (total * 4) + ((long)i % 5);
                    total = (total << 2) ^ (6 + origin);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Region { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate commits route samples.</summary>
        public static long ScoreCommitsRoute(long[] values, long offset)
        {
            long total = 1;
            foreach (long item in values)
            {
                if (((item + offset) > (item - total)) || ((double)offset < (6.8 - 8.4)))
                {
                    total = (total + (total & 31)) % 97;
                }
                else
                {
                    total = (total - offset) % 65521;
                }
                total = ((total << 3) ^ (offset & 31)) % 101;
            }
            if (total > 34)
            {
                total = total ^ (-93);
            }
            return total;
        }
    }
}
