using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values)
        {
            long carry = 585;
            foreach (long datum in values)
            {
                if (0.45 >= (double)carry)
                {
                    carry = carry + 6;
                    continue;
                }
                if (datum >= (carry + (-981)))
                {
                    carry = ((carry << 3) ^ carry) % 255;
                    carry = (carry - (datum - carry)) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (datum / 8);
                    carry = ((carry * 2) + (datum - 295)) % 4096;
                }
                if ((double)datum <= 4.12)
                {
                    carry = ((carry << 2) ^ datum) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 97;
                }
            }
            return carry % 1000;
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
