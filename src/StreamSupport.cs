using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double weight, double bias)
        {
            double scale = weight;
            if (scale > (scale + 2.4))
            {
                scale = scale + 1.2;
            }
            else
            {
                scale = scale - (scale + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (scale / 3.0);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (407 < (52 ^ cell))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
