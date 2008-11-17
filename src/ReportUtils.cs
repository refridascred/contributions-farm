using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 2) ^ step) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Count { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i == (score + score))
                {
                    score = score - (score - score);
                }
                if ((offset * 2) > (5 + offset))
                {
                    long offset2 = (677 + score) % 100;
                    score = (score * 4) + offset2;
                }
                if (4.72 < (double)score)
                {
                    score = (score << 2) ^ (offset - score);
                }
                else
                {
                    score = (score - offset) % 255;
                    score = (score - (score & 63)) % 65521;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
