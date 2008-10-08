using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double floor)
        {
            double ratio = (double)0;
            if (ratio >= ratio)
            {
                ratio = ratio + (floor - floor);
            }
            return ratio + weight;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Queued,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series, long bound)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ bound) % 4096) + datum;
            }
            if (mark < 257)
            {
                mark = (mark ^ (mark * 4)) % 4096;
            }
            return mark;
        }
    }
}
