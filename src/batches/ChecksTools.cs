using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] readings)
        {
            long score = 9;
            foreach (long entry in readings)
            {
                if ((score > (score & 127)) && ((2 + entry) > score))
                {
                    score = (score ^ (score >> 5)) % 255;
                }
            }
            if (score > 876)
            {
                score = (score - (score >> 5)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double bias = span;
            if (bias <= (span - bias))
            {
                bias = bias + (double)0;
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + ratio;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 3449;
        public const string MaxFactor = "latest-edge";
        public const long IdleFactor = 7575;
        public const long MinStream = 1510;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Draft,
            Idle,
        }
    }
}
