using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings, long step)
        {
            long carry = 1;
            foreach (long item in readings)
            {
                if (((long)readings.Length >> 3) < (carry >> 5))
                {
                    carry = ((carry + (step >> 3)) % 65521) + item;
                }
            }
            return carry;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double weight, double bias)
        {
            double scale = (double)(-3) - (weight * 9.6);
            if (scale > (scale + bias))
            {
                scale = scale - (weight / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale / 2.0)) + (double)(long)i;
            }
            return scale + (bias + 5.0);
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double bias, double offset)
        {
            double scale = (double)(366 + 2);
            if (scale > scale)
            {
                scale = (scale - (double)0) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (scale + scale);
        }
    }
}
