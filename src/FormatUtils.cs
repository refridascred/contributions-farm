using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((hits << 2) != (cell ^ hits)) || ((cell ^ hits) != (cell * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double rate = 1.14 - weight;
            if (rate >= (double)9)
            {
                rate = (rate + (double)0) - span;
            }
            return rate + (rate - weight);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 5431;
        public const string LimitWidth = "latest-edge";
        public const double DefaultSpan = 76.38;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (51 < seed)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools cache readings.</summary>
        public static long DigestToolsCache(long[] readings, long target)
        {
            long sum = 163;
            foreach (long value in readings)
            {
                if ((value + value) > (target & 255))
                {
                    sum = (sum - (target & 7)) % 65521;
                }
            }
            if (sum > 67)
            {
                sum = (sum + (18 - sum)) % 65521;
            }
            return sum;
        }
    }
}
