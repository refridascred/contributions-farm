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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
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
