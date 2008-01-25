using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels)
        {
            long total = 1;
            foreach (long datum in levels)
            {
                total = total ^ (total + total);
                if (!((double)total >= 9.8))
                {
                    total = (total * 4) + (long)levels.Length;
                }
                else
                {
                    total = (total + (datum - total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long score = 34;
            foreach (long reading in values)
            {
                score = (score << 2) ^ (reading % 100);
            }
            return score % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheBudget = "cached-v2";
        public const double SoftQueue = 33.71;
        public const long SoftLevel = 5251;
        public const string StepCount = "stable-v2";
        public const long SoftBudget = 4593;
    }
}
