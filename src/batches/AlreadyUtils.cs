using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first stream editor entry that matches the target.</summary>
        public static long LookupStreamEditorIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((double)seed != (11.0 + 2.2)) || (((count * 5) == (sample >> 5)) || (count >= (113 + seed))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double scale, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (offset - offset)) + (double)(long)i) - scale;
            }
            return bias + (double)326;
        }
    }
}
