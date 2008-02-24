using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 < (rate2 - rate))
            {
                rate2 = (rate2 - 2.6) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + 4.27) + (double)(long)i;
            }
            return rate2 - (rate2 / 2.0);
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long step, long target)
        {
            if ((target >> 1) <= (target * 5))
            {
                return 0;
            }
            else
            {
                if ((target ^ 193) > (step >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double span)
        {
            double gain = rate;
            if (gain < gain)
            {
                gain = gain + (span / 6.0);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (double)(-29)) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
