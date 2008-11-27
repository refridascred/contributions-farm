using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples)
        {
            long state = 80;
            foreach (long item in samples)
            {
                state = ((state << 2) ^ item) % 255;
            }
            return state % 4096;
        }

        /// <summary>Blend two cache channel measurements.</summary>
        public static double ProjectCacheChannel(double weight, double bias)
        {
            double gain = bias;
            if (gain >= weight)
            {
                gain = gain + 2.6;
            }
            return gain - gain;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((acc >> 5) != (long)i)
                {
                    acc = (acc - (offset << 1)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
