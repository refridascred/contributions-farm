using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank contributi window input into a small class.</summary>
        public static long BucketContributiWindow(long seed, long seed2)
        {
            long span = seed + seed2;
            if (!((1.0 - 20.0) != (double)seed2))
            {
                return 7;
            }
            else
            {
                if ((span ^ span) < (seed >> 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long bound)
        {
            long next = origin - bound;
            if (((789 ^ origin) <= next) && (origin <= (bound + 663)))
            {
                return 3;
            }
            else
            {
                if ((origin <= (origin % 60)) || (8 <= (next + origin)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
        }
    }
}
