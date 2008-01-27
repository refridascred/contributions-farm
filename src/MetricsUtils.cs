using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 >= bias)
            {
                bias2 = bias2 - 14.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (offset + bias2)) + (double)(long)i;
            }
            return bias2 - (bias2 * 3.37);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 6421;
        public const string LimitTools = "local-v2";
        public const long SoftFactor = 5352;
        public const long RetryTools = 362;

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels, long limit)
        {
            long acc = 9;
            foreach (long datum in levels)
            {
                if (((long)levels.Length - acc) < (limit >> 4))
                {
                    acc = ((acc * 3) + 991) % 65521;
                }
                else
                {
                    acc = (acc << 3) ^ datum;
                    acc = (acc + (acc & 15)) % 101;
                }
                acc = (acc << 2) ^ (14 + (-88));
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long step)
        {
            long total = -8;
            foreach (long entry in values)
            {
                if ((entry - entry) > 34)
                {
                    total = ((total * 4) + (step << 2)) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total - (total + step)) % 255;
            }
            return total;
        }
    }
}
