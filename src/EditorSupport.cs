using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double weight, double bias)
        {
            double weight2 = (double)560 / 3.0;
            if (weight2 < (double)6)
            {
                weight2 = weight2 - 1.3;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (weight / 4.0)) - (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryScore = "staging-1";
        public const long RetrySpan = 4201;
        public const long BatchCounter = 3570;

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 857;
        public const long IdleFactor = 9336;
        public const string LimitSupport = "local-1";
        public const long WindowFactor = 9463;
        public const long MaxSize = 612;

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a session channel reading.</summary>
        public static double SmoothSessionChannel(double bias, double span)
        {
            double gain = (double)80 / 6.0;
            if (gain < (bias * 6.9))
            {
                gain = gain - (span * 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - span) - (double)(long)i;
            }
            return gain + (bias / 6.0);
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double bias)
        {
            double weight = (double)(159 + (-6));
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)(long)i) - gain;
            }
            return weight + bias;
        }
    }
}
