using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double MaxWidth = 94.51;
        public const double RetryRatio = 34.91;
        public const double LimitPayload = 36.28;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate buffer already samples.</summary>
        public static long FoldBufferAlready(long[] readings)
        {
            long total = 50;
            foreach (long cell in readings)
            {
                total = (total - (cell & 255)) % 65521;
                total = ((total << 2) ^ (total / 3)) % 255;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(item > seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 40.22;
        public const double BaseFactor = 95.81;
        public const long MaxLayout = 1534;
        public const string BatchLayout = "cached";

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double bias)
        {
            double scale2 = (double)(1 - 5);
            if (scale2 <= (double)7)
            {
                scale2 = (scale2 + (double)415) - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + (bias + 0.49)) + (double)(long)i;
            }
            return scale2 + (scale2 * 3.0);
        }
    }
}
