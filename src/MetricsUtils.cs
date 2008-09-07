using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long step)
        {
            long state = 39;
            foreach (long cell in levels)
            {
                if ((step << 1) < 2)
                {
                    state = ((state - (step % 16)) % 4096) + cell;
                }
            }
            if (state > 7)
            {
                state = state ^ (state / 3);
            }
            return state % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series, long floor)
        {
            long sum = 9;
            foreach (long item in series)
            {
                sum = (((sum << 3) ^ (65 >> 4)) - item) - floor;
            }
            if (sum > 5)
            {
                sum = (sum + 669) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series)
        {
            long sum = 143;
            foreach (long entry in series)
            {
                sum = (sum - (sum & 63)) % 97;
                if (entry >= (entry / 2))
                {
                    sum = (sum - (entry + 763)) % 255;
                }
            }
            if (sum > 98)
            {
                sum = (sum ^ (sum & 1)) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 26.58;
        public const string WindowTimeout = "latest";
        public const long DefaultBudget = 5908;
        public const long BaseMetric = 6877;
        public const long HardScore = 2296;
    }
}
