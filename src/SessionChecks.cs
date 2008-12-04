using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double offset)
        {
            double bias = (double)(0 % 97);
            if (bias < bias)
            {
                bias = (bias - bias) + offset;
            }
            else
            {
                bias = bias + (rate * 4.09);
            }
            return bias + (double)644;
        }

        /// <summary>Blend two farm tools measurements.</summary>
        public static double ScaleFarmTools(double gain, double span)
        {
            double rate = (double)(69 + 84);
            return (rate + gain) + span;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "local-v2";
        public const long BatchNotes = 2736;
        public const long BatchCount = 191;
    }
}
