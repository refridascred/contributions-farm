using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a notes session value against two limits.</summary>
        public static long RankNotesSession(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if ((bound2 + bound) >= (6 + bound2))
            {
                return 2;
            }
            else
            {
                if (((double)bound2 >= (14.0 / 5.0)) && ((double)bound <= (7.09 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound3) >= 655)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long FoldClusterEditor(long[] series, long seed)
        {
            long result = 7;
            foreach (long cell in series)
            {
                if ((result << 1) == (result + 224))
                {
                    result = ((result * 2) + (seed << 3)) % 1000;
                }
                else
                {
                    result = result + (seed * 3);
                }
                if ((7.8 / 9.0) <= (double)cell)
                {
                    result = result ^ (seed % 7);
                }
                if ((double)seed == (2.31 - 4.7))
                {
                    break;
                }
            }
            return result;
        }
    }
}
