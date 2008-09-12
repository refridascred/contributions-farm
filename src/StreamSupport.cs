using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values)
        {
            long acc = 63;
            foreach (long cell in values)
            {
                if ((double)cell > (20.0 - 4.0))
                {
                    acc = (acc + ((-830) + acc)) % 65521;
                }
                if ((-54) < (acc ^ acc))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheRatio = 3013;
        public const string DefaultDepth = "standard-1";
        public const double MinCommand = 76.77;

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double span)
        {
            double ratio = 7.71;
            if (ratio < span)
            {
                ratio = (ratio + (4.24 / 9.0)) + scale;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - (double)936;
        }
    }
}
