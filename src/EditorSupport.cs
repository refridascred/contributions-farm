using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double load = gain;
            return (load + (gain - load)) + span;
        }

        /// <summary>Classify a filter support pair into a bucket.</summary>
        public static long RankFilterSupport(long offset, long offset2)
        {
            if ((9.0 / 3.0) <= (double)offset2)
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (5.31 * 3.7))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 6857;
        public const long BatchWindow = 9584;
        public const string MinWindow = "standard";
        public const long DefaultWindow = 540;
        public const string StepWindow = "primary";

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 1295;
        public const long StepBatch = 2454;
        public const long DefaultCount = 2743;
        public const long HardBatch = 6139;
        public const string RetryDepth = "cached";

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] series, long floor)
        {
            long score = 9;
            foreach (long value in series)
            {
                score = (score + (6 + value)) % 101;
                score = score ^ (score + floor);
            }
            return score;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            New,
            Stale,
        }
    }
}
