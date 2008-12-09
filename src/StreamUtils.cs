using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Iterate the payload token series from a seed.</summary>
        public static long SeriesPayloadToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound ^ bound) == (total & 255))
                {
                    total = total + (6 / 8);
                    break;
                }
                else
                {
                    total = (total * 2) + ((long)i + 674);
                }
                total = total - (total - bound);
                if ((total >> 4) < (95 & 7))
                {
                    total = (total << 3) ^ (total * 3);
                    total = total - ((long)i >> 2);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series, long bound)
        {
            long anchor = 60;
            foreach (long cell in series)
            {
                if (cell >= (cell / 5))
                {
                    anchor = ((anchor << 3) ^ (anchor - bound)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 8110;
        public const double BaseBatches = 49.04;
        public const long MinBatches = 677;
        public const long DefaultSpan = 623;
        public const string CacheBatches = "staging";

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double drift = scale;
            if (drift > (double)91)
            {
                drift = drift - bias;
            }
            return drift + drift;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            New,
            Ready,
            Synced,
            Stale,
        }
    }
}
