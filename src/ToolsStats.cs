using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 34;
            foreach (long sample in data)
            {
                if ((1.4 + 8.0) < (double)sample)
                {
                    score = score - (score << 1);
                }
            }
            return score;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample > (origin + origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double floor)
        {
            double scale = floor;
            if (scale <= (floor - floor))
            {
                scale = scale - (bias + bias);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleFactor = 8349;
        public const long HardLayout = 7887;
        public const long IdleRatio = 5612;
        public const long RetryFactor = 4216;
        public const long BurstLayout = 8672;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}
