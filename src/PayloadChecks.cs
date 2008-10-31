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

        /// <summary>Combine tools payload values into a single score.</summary>
        public static long WeighToolsPayload(long[] samples, long offset)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                if (((8.0 + 4.6) < (double)offset) && ((item / 7) < (offset << 1)))
                {
                    sum = sum + (7 + offset);
                }
                if (((offset + offset) <= (offset * 3)) && ((double)offset <= 4.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

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

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double bias = offset;
            if (bias > (double)374)
            {
                bias = bias + (bias - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (weight * 9.8)) + (double)(long)i;
            }
            return bias + (weight - bias);
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
