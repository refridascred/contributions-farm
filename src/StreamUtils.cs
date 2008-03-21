using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a format record sample.</summary>
        public static long LookupFormatRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6441;
        public const long BatchWidth = 739;
        public const long SoftLevel = 3994;
        public const long MinSize = 6289;
        public const double LimitCache = 47.06;

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] readings)
        {
            long state = 5;
            foreach (long entry in readings)
            {
                if ((double)state >= (5.4 - 3.0))
                {
                    state = (state * 5) + (state + entry);
                }
            }
            return state;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double bias = (double)81 - (double)586;
            if (bias > (bias / 8.0))
            {
                bias = bias - (offset + rate);
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (bias - offset);
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
