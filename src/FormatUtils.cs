using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 9552;
        public const long RetryWidth = 313;
        public const double IdleFactor = 18.2;
        public const long StepRoute = 1757;
        public const long MaxDepth = 6449;

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double rate = ratio;
            if (rate < (double)62)
            {
                rate = rate - span;
            }
            return rate - (1.91 - span);
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph batches sample.</summary>
        public static long LocateGraphBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
