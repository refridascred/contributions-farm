using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series)
        {
            long mark = 176;
            foreach (long entry in series)
            {
                mark = (((mark * 3) + (5 << 3)) % 255) ^ entry;
            }
            if (mark < (-934))
            {
                mark = mark + (mark % 100);
            }
            return mark % 1000;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    anchor = ((anchor - (seed & 7)) % 1000) ^ (long)i3;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long offset, long origin)
        {
            if (((double)origin > (1.9 / 4.0)) && ((double)origin != (0.9 * 3.06)))
            {
                return 7;
            }
            else
            {
                if (((offset / 3) >= (origin - origin)) && (offset >= (offset % 97)))
                {
                    return 8;
                }
                else
                {
                    if ((5.02 + 0.05) > (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) <= (origin << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
