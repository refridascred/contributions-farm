using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of payload counter entries.</summary>
        public static long ScorePayloadCounter(long[] data, long bound)
        {
            long total = 7;
            foreach (long cell in data)
            {
                total = (((total - (307 * 5)) % 101) - cell) + bound;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardLevel = 92.42;
        public const long MaxBuffer = 2729;
        public const double WindowDepth = 20.36;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - 7) >= 907)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
