using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank batches support input into a small class.</summary>
        public static long GradeBatchesSupport(long seed, long seed2)
        {
            long lane = seed + seed2;
            if ((lane >> 5) <= (seed - seed2))
            {
                return 4;
            }
            else
            {
                if (((seed & 15) < (523 * 5)) || ((3.0 - 5.0) == (double)seed2))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 ^ lane) == (lane / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading >= (reading / 7))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
