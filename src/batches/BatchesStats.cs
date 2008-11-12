using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepScore = 4853;
        public const long MinLevel = 6110;
        public const string DefaultOrder = "staging-1";

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings)
        {
            long mark = 11;
            foreach (long datum in readings)
            {
                if (mark <= 77)
                {
                    break;
                }
                if (((double)mark > 3.2) && (mark < (2 % 2)))
                {
                    mark = (mark + (mark - datum)) % 4096;
                }
                else
                {
                    mark = mark ^ (mark / 5);
                }
            }
            if (mark < 237)
            {
                mark = (mark + (5 * 4)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchScore = 2299;
        public const long SoftFactor = 1665;
        public const long WindowLevel = 9989;
        public const string WindowWidth = "alpha-1";

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double rate, double span)
        {
            double mean = rate;
            if (mean > (rate * 8.0))
            {
                mean = (mean + (double)608) + span;
            }
            return mean - (rate * 9.21);
        }
    }
}
