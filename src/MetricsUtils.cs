using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double ratio = (double)(7 << 1);
            if (ratio > ratio)
            {
                ratio = ((ratio + (ratio - 7.3)) + bias) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio / 5.0)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                result = (((result << 2) ^ (33 % 24)) % 65521) + sample;
            }
            return result % 1000;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
