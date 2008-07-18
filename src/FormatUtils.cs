using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double rate, double bias)
        {
            double drift = 1.66;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (rate + rate)) + (double)(long)i) - bias;
            }
            return drift - (9.4 / 5.0);
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix << 3) ^ (mix << 3);
                mix = ((mix * 2) + origin) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
