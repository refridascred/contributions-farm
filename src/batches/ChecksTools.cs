using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double weight, double span)
        {
            double mean = weight + (span / 9.0);
            if (mean < (double)165)
            {
                mean = mean + (double)689;
            }
            return mean + (14.0 - mean);
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i / 9) > (mix - mix))
                {
                    mix = mix - (long)i;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] values)
        {
            long total = 19;
            foreach (long item in values)
            {
                total = ((total << 3) ^ (item + item)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long DeriveChecksCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc << 3) ^ (acc << 2);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
