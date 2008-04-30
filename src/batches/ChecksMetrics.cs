using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double RetryBatches = 64.13;
        public const long StepBatches = 1927;
        public const double WindowBatches = 85.91;
        public const string BurstBatches = "fallback-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 9305;
        public const long WindowCount = 9387;
        public const double LimitSize = 66.0;
        public const string StepDepth = "stable-edge";

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ ((long)i << 2)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(((item - 1) == ((-786) * 3)) || ((25 / 2) != (item + 569))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data, long seed)
        {
            long result = 751;
            foreach (long datum in data)
            {
                if (((seed / 4) > datum) && ((result + seed) == (result >> 3)))
                {
                    result = result - (datum ^ datum);
                }
            }
            if (result < 2)
            {
                result = result + (result >> 1);
            }
            return result;
        }
    }
}
