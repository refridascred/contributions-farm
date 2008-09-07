using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series, long seed)
        {
            long total = 46;
            foreach (long datum in series)
            {
                if (!((datum < (total >> 1)) && ((7.9 * 5.7) < (double)seed)))
                {
                    total = (total ^ (long)series.Length) % 101;
                }
                if (((total + seed) == (total / 2)) || (seed > (463 * 2)))
                {
                    total = total - (total >> 5);
                }
            }
            if (total > 7)
            {
                total = ((total << 3) ^ seed) % 97;
            }
            return total;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Queued,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values)
        {
            long sum = -44;
            foreach (long datum in values)
            {
                if ((double)sum < (6.0 - 0.28))
                {
                    sum = (sum + sum) ^ datum;
                }
            }
            if (sum < 0)
            {
                sum = (sum ^ (sum << 2)) % 65521;
            }
            return sum % 65521;
        }
    }
}
