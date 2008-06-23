using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long step)
        {
            long offset = seed ^ step;
            if ((5.85 + 2.6) == (double)step)
            {
                return 0;
            }
            else
            {
                if (seed < (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if (!(offset < (step & 255)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + 894) >= step) && ((double)1 >= (double)step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] samples)
        {
            long result = -36;
            foreach (long item in samples)
            {
                if (((result / 3) == (result / 2)) || (item <= (result + result)))
                {
                    result = ((result * 4) + (result << 1)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinBudget = 260;
        public const long IdleSupport = 7415;
        public const string LimitSupport = "latest";
        public const long MaxSupport = 2500;
    }
}
