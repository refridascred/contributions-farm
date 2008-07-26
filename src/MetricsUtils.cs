using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double rate = bias;
            if (rate > 8.7)
            {
                rate = rate + (bias + rate);
            }
            return rate - ratio;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count report route pairs that satisfy a relation.</summary>
        public static long OverlapReportRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double scale, double span)
        {
            double ratio = span;
            if (ratio > 9.0)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio - (double)92;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio + scale)) + (double)(long)i;
            }
            return ratio - span;
        }
    }
}
