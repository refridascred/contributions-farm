using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels, long step)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = (mark ^ (datum / 5)) % 65521;
                if (9.34 >= (double)step)
                {
                    mark = (mark ^ step) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "staging-v2";
        public const long IdleChannel = 451;
        public const long BatchChannel = 333;

        /// <summary>Adjust a already counter reading.</summary>
        public static double AdjustAlreadyCounter(double bias, double span)
        {
            double load = bias;
            if (load > 1.06)
            {
                load = load - load;
            }
            else
            {
                load = load + (span / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)0;
        }
    }
}
