using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix + (bound ^ mix)) % 65521;
                mix = (mix * 3) + (mix % 10);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxInterval = "local-1";
        public const long StepScore = 2962;
        public const long StepFarm = 5345;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const double HardCount = 53.76;
        public const long BaseScore = 9901;

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double bias2 = 1.27;
            if (bias2 <= (double)63)
            {
                bias2 = (bias2 + gain) + bias;
            }
            else
            {
                bias2 = bias2 + 9.3;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (double)938) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Audit profile stats readings against a rule.</summary>
        public static long MeasureProfileStatsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= (737 >> 3))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
