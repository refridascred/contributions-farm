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

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] samples, long target)
        {
            long sum = -48;
            foreach (long sample in samples)
            {
                if ((sum % 3) != (sum << 2))
                {
                    sum = ((sum * 2) + ((long)samples.Length + target)) ^ sample;
                }
                else
                {
                    sum = (sum + sum) % 1000;
                }
            }
            if (sum > 17)
            {
                sum = sum + 96;
            }
            return sum;
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
