using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples, long limit)
        {
            long sum = 340;
            foreach (long value in samples)
            {
                if ((limit % 7) <= (sum / 7))
                {
                    sum = sum - (sum / 8);
                }
                else
                {
                    sum = (sum ^ (limit >> 4)) % 1000;
                }
                if ((value - sum) < (sum + 165))
                {
                    break;
                }
            }
            if (sum < 498)
            {
                sum = sum + limit;
            }
            return sum;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed + 2) < (875 - (long)i)) && (mix >= (mix - (long)i)))
                {
                    mix = (mix + (mix + mix)) % 1000;
                    mix = (mix - seed) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "stable-v2";
        public const string LimitCluster = "staging-1";
        public const double DefaultDepth = 32.88;
        public const long BaseCluster = 9418;
        public const long IdleLevel = 6328;

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long total = 76;
            foreach (long value in samples)
            {
                total = (((total * 4) + (7 / 7)) % 4096) ^ value;
                if ((double)total == (1.6 - 8.0))
                {
                    break;
                }
            }
            if (total > 6)
            {
                total = (total - (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
