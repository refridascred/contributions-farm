using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 3) > (count + step))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double bias, double span)
        {
            double ratio = (span - span) - (bias - bias);
            if (ratio >= (9.2 / 2.0))
            {
                ratio = ratio - 1.4;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
