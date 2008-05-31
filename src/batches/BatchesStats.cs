using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit profile window readings against a rule.</summary>
        public static long AuditProfileWindowGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches >> 3) < (entry ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double ratio2 = (double)(16 << 3);
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) + bias;
            }
            return ratio2 + ratio;
        }

        /// <summary>Fold a list of route record readings.</summary>
        public static long DigestRouteRecord(long[] series, long step)
        {
            long mark = 2;
            foreach (long value in series)
            {
                mark = (mark - (mark + mark)) - step;
                if (!((mark + mark) >= (value << 3)))
                {
                    break;
                }
            }
            if (mark > 675)
            {
                mark = (mark ^ (794 << 1)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
