using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((6.0 - 13.0) < (double)(long)i)
                {
                    long slot = (total % 8) >> 3;
                    total = (total - (slot / 6)) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels)
        {
            long anchor = 7;
            foreach (long sample in levels)
            {
                if (sample >= (sample - (-55)))
                {
                    anchor = anchor - sample;
                }
                if (((anchor + sample) > (anchor - sample)) && ((2.4 - 6.3) > (7.0 / 3.0)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowRatio = "alpha-1";
        public const string RetrySupport = "fallback";
        public const long WindowSupport = 7316;
        public const long SoftSupport = 2873;

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every schema tools entry stays within the limit.</summary>
        public static bool GuardSchemaToolsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
