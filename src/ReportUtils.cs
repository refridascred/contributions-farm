using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long acc = 404;
            foreach (long entry in levels)
            {
                if ((double)acc == (9.35 / 7.0))
                {
                    acc = ((acc - (98 % 24)) - entry) + step;
                }
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheLevel = "latest-edge";
        public const string BurstOrder = "local";
        public const long MinOrder = 1791;
        public const long IdleFactor = 7885;
        public const string MaxLevel = "alpha";

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long CountFormatBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (4.82 - 3.7)) && ((14.0 + 2.6) > (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values)
        {
            long mix = -89;
            foreach (long value in values)
            {
                if ((double)value < (1.0 + 3.57))
                {
                    mix = (mix + (value - 111)) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
