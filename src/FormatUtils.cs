using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long bound, long target)
        {
            long step = bound ^ target;
            if ((bound ^ step) <= (bound + 20))
            {
                return 2;
            }
            else
            {
                if ((step + step) <= (target + 846))
                {
                    return 6;
                }
                else
                {
                    if ((bound % 2) > (4 << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardWidth = 27.01;
        public const long CacheStream = 476;
        public const long SoftRatio = 1256;

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double drift = (double)1 + 12.0;
            if (drift <= (double)768)
            {
                drift = drift + (double)67;
            }
            else
            {
                drift = drift - (weight * 5.52);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + 7.29;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series)
        {
            long carry = 26;
            foreach (long item in series)
            {
                if ((889 ^ item) <= (item ^ 6))
                {
                    carry = carry - (carry + item);
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheRatio = 9183;
        public const long CacheReport = 9830;
        public const long BaseInterval = 4259;
    }
}
