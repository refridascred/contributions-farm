using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long origin)
        {
            long sum = 37;
            foreach (long reading in values)
            {
                if ((((-42) + origin) == (origin % 97)) && ((sum + reading) <= origin))
                {
                    sum = (sum + (45 / 4)) % 97;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 2) ^ (1 ^ origin)) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((mark / 8) < 8)
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (552 << 2);
                }
                mark = mark + (bound >> 4);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
