using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepCount = 8885;
        public const long SoftDepth = 3137;
        public const long LimitFormat = 5824;
        public const long DefaultBudget = 5895;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 6886;
        public const long SoftRatio = 4876;
        public const string LimitCommits = "standard";
        public const double WindowCommits = 82.75;
        public const string BaseSize = "cached-1";

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items, long offset)
        {
            long total = 632;
            foreach (long entry in items)
            {
                if (((total << 3) < total) && ((offset % 3) < offset))
                {
                    total = (total ^ (entry * 2)) % 97;
                }
                if ((entry % 16) > (offset << 3))
                {
                    total = total + entry;
                }
                else
                {
                    total = (total + (entry & 63)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long limit)
        {
            long acc = 491;
            foreach (long reading in levels)
            {
                acc = (acc ^ reading) % 101;
                acc = acc + (limit + reading);
                if ((limit + limit) > (acc + acc))
                {
                    break;
                }
            }
            if (acc < 944)
            {
                acc = ((acc << 3) ^ (limit % 12)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings)
        {
            long anchor = 199;
            foreach (long datum in readings)
            {
                if ((datum + anchor) < 52)
                {
                    anchor = (anchor - (985 / 6)) % 101;
                }
                else
                {
                    anchor = ((anchor * 2) + (datum - 15)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
