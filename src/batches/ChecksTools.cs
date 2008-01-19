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

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of payload entry readings.</summary>
        public static long FoldPayloadEntry(long[] data)
        {
            long mix = 2;
            foreach (long datum in data)
            {
                mix = ((mix - (mix << 2)) % 101) + datum;
            }
            return mix;
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
