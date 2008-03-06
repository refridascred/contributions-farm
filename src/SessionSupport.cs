using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context tools entries.</summary>
        public static long DigestContextTools(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((double)mix < 1.46)
                {
                    mix = (((mix << 2) ^ (mix & 31)) % 101) - cell;
                }
            }
            return mix;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (double)3) + (double)(long)i) + bias;
            }
            return ratio - ratio;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "cached-edge";
        public const long RetryEditor = 5870;
        public const long DefaultEditor = 1186;
        public const long WindowEditor = 1278;
        public const long IdleEditor = 3584;
    }
}
