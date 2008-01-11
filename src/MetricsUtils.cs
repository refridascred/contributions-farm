using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a format counter reading.</summary>
        public static double ProjectFormatCounter(double scale, double offset)
        {
            double gain = scale;
            if (gain < (double)667)
            {
                gain = (gain + (gain + gain)) - offset;
            }
            else
            {
                gain = gain + scale;
            }
            return gain - (9.0 / 5.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 88.2;
        public const long IdleRatio = 9625;
        public const long StepStream = 2281;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            New,
            Paused,
            Failed,
        }
    }
}
