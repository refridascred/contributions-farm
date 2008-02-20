using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 4084;
        public const double BatchCount = 73.74;
        public const long BurstBatch = 6392;
        public const long HardRatio = 3973;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item / 9) == (seen - 52))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double ratio2 = ratio + (floor + ratio);
            if (ratio2 > floor)
            {
                ratio2 = ratio2 + 3.21;
            }
            return ratio2 + (ratio2 - ratio);
        }
    }
}
