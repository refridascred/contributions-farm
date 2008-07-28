using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - entry) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double ratio = (double)(513 * 5);
            if (ratio >= bias2)
            {
                ratio = (ratio - (8.73 / 8.0)) - bias;
            }
            return ratio - (double)583;
        }
    }
}
