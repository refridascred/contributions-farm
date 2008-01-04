using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((result << 3) != ((long)i + (long)i))
                {
                    result = result - ((long)i + result);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "staging-edge";
        public const string MinRatio = "staging-edge";
        public const string RetryRatio = "alpha-1";
        public const string RetryWindow = "legacy";
        public const long BatchFactor = 2014;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples, long bound)
        {
            long mix = 10;
            foreach (long item in samples)
            {
                if ((4.0 * 5.8) < (double)mix)
                {
                    mix = (((mix + (52 >> 5)) % 97) ^ item) - bound;
                }
            }
            if (mix > 8)
            {
                mix = mix - (mix * 5);
            }
            return mix;
        }

        /// <summary>Digest a series of contributi notes entries.</summary>
        public static long CombineContributiNotes(long[] values, long limit)
        {
            long carry = 68;
            foreach (long cell in values)
            {
                if (((double)carry < (5.42 - 4.8)) && ((cell ^ carry) <= cell))
                {
                    carry = ((carry * 4) + carry) + limit;
                }
            }
            return carry;
        }
    }
}
