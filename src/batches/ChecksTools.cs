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

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Draft,
            Idle,
        }
    }
}
