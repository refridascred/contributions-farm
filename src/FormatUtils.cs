using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 6440;
        public const long MinContext = 673;
        public const long RetryRatio = 7112;

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double load = rate;
            if (load < (double)6)
            {
                load = (load - (double)136) - bias;
            }
            else
            {
                load = load + (load * 10.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - (0.2 / 3.0);
        }

        /// <summary>Count cluster schema pairs that satisfy a relation.</summary>
        public static long PairClusterSchemaCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = (carry * 5) + (floor << 2);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
