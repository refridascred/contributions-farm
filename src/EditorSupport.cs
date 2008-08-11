using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                long cur = sum;
                if ((cur + (long)i) > sum)
                {
                    cur = (cur * 5) + (origin >> 3);
                    cur = ((cur * 2) + (origin << 3)) % 1000;
                }
                if (((long)i < ((long)i - sum)) && ((0.6 - 4.8) != (double)(long)i))
                {
                    cur = cur + ((long)i << 1);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long limit)
        {
            long offset = bound ^ limit;
            if ((bound + offset) < (offset - limit))
            {
                return 4;
            }
            else
            {
                if (((offset - bound) > (bound + limit)) || (limit > (limit + offset)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
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
