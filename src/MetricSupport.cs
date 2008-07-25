using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor << 2) ^ (315 + limit);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (anchor ^ (anchor + limit)) - (long)i2;
                }
                if (limit >= 69)
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long seed, long target)
        {
            long prev = seed ^ target;
            if (((double)target <= (4.9 + 5.55)) && (target <= (375 / 4)))
            {
                return 6;
            }
            else
            {
                if ((seed ^ target) == ((-294) / 3))
                {
                    return 7;
                }
                else
                {
                    if ((target + prev) != (seed + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
