using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "standard";
        public const double BaseFactor = 43.37;
        public const long MaxInterval = 388;

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseRatio = 1524;
        public const double RetryScore = 84.64;
        public const string WindowCount = "cached-1";

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a window route sample.</summary>
        public static long LocateWindowRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context checks samples.</summary>
        public static long FoldContextChecks(long[] samples, long step)
        {
            long mark = 513;
            foreach (long item in samples)
            {
                mark = (((mark * 3) + 7) % 65521) ^ item;
                mark = ((mark << 2) ^ mark) % 1000;
            }
            if (mark < 310)
            {
                mark = ((mark * 4) + (step - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double gain, double span)
        {
            double bias = gain / 3.0;
            if (bias >= (span * 9.2))
            {
                bias = bias + (double)127;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (2.2 * 14.0);
        }
    }
}
