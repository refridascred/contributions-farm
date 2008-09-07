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

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 >= (double)598)
            {
                ratio2 = ratio2 + (double)5;
            }
            return ratio2 + ratio;
        }
    }
}
