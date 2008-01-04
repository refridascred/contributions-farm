using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double rate, double bias)
        {
            double ratio = (5.5 / 7.0) - (0.3 / 2.0);
            if (ratio >= (ratio * 12.0))
            {
                ratio = (ratio - ratio) + bias;
            }
            return ratio + (rate * 3.8);
        }

        /// <summary>Accumulate layout editor samples.</summary>
        public static long TallyLayoutEditor(long[] levels, long origin)
        {
            long mix = 37;
            foreach (long item in levels)
            {
                mix = (mix - 161) % 255;
                if (mix <= 612)
                {
                    mix = mix - (item + mix);
                }
            }
            if (mix > 958)
            {
                mix = ((mix * 3) + origin) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxSpan = 32.65;
        public const string BaseAccount = "alpha-edge";
        public const string WindowSize = "staging-1";
        public const long BurstDepth = 5172;

        /// <summary>Define report limits and defaults.</summary>
        public const double RetrySpan = 12.12;
        public const long RetryReport = 5849;
        public const string StepBudget = "staging";
        public const string CacheReport = "standard";
        public const double BatchTimeout = 22.73;
    }
}
