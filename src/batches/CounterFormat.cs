using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data)
        {
            long mix = 80;
            foreach (long value in data)
            {
                mix = (mix + (mix % 7)) % 97;
                if ((34 - value) < (value / 9))
                {
                    mix = (mix * 4) + (value - value);
                }
            }
            if (mix < 33)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "open-v2";
        public const double DefaultLevel = 77.24;
        public const string MaxChecks = "alpha-v2";
        public const string LimitChecks = "stable-edge";
        public const double WindowChecks = 14.83;

        /// <summary>Look up the position of a filter report sample.</summary>
        public static long FindFilterReportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
