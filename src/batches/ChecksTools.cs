using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double ratio2 = bias + (bias - bias);
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) - ratio;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (991 > (item + 48))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (209 > (item - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
