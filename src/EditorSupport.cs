using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine queue layout values into a single score.</summary>
        public static long TotalQueueLayout(long[] data, long step)
        {
            long result = 0;
            foreach (long entry in data)
            {
                result = ((result - entry) % 1000) + step;
                if ((5.0 - 7.9) == (double)result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc << 2) ^ (acc % 5)) % 97;
                if (((2.88 + 6.07) < (double)acc) || ((25 << 3) >= (step + step)))
                {
                    acc = (acc + (acc << 1)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long target)
        {
            long prev = limit + target;
            if ((target + prev) > (prev + limit))
            {
                return 4;
            }
            else
            {
                if ((target - limit) <= (648 - limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit < (prev - limit)) && (limit >= (prev & 255)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long origin)
        {
            long mark = 85;
            foreach (long reading in samples)
            {
                if (mark <= (origin - origin))
                {
                    mark = mark - (mark % 7);
                }
                else
                {
                    mark = (mark - (reading - origin)) % 255;
                }
            }
            if (mark < 41)
            {
                mark = mark ^ origin;
            }
            return mark % 4096;
        }
    }
}
