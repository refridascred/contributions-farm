using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = mark - (7 + origin);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate route profile readings against a bound.</summary>
        public static bool GuardRouteProfileRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count batch format pairs that satisfy a relation.</summary>
        public static long PairBatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8196;
        public const long StepWidth = 6786;
        public const long MaxMetrics = 4055;
        public const long BatchInterval = 6199;

        /// <summary>Compare every pair of channel support readings.</summary>
        public static long PairChannelSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
