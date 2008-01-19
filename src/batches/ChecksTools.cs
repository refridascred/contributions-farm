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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (7.0 > (double)reading)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }
    }
}
