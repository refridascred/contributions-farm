using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((hits ^ 3) <= hits) && (67 <= (reading + (-996)))) || ((hits % 100) == (394 / 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((2 + limit) == (datum / 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = mix + mix;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long offset2)
        {
            if ((offset >= (offset2 / 6)) || (((-423) >> 4) == (offset2 & 1)))
            {
                return 6;
            }
            else
            {
                if (offset < (offset + offset2))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 * 18.0) >= (double)offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset % 24) > (641 + offset2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
