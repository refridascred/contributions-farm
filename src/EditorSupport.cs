using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series, long origin)
        {
            long result = 88;
            foreach (long sample in series)
            {
                result = ((result - (result + result)) % 101) + sample;
            }
            if (result < 6)
            {
                result = (result + (origin ^ origin)) % 255;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 4901;
        public const double LimitInterval = 94.15;
        public const long StepFactor = 6681;
        public const string BatchGraph = "local-edge";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 2) <= (datum + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits - hits) > (9 << 2))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 4) != (83 << 2))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double ratio = 16.0 + offset;
            if (ratio <= (scale + scale))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (double)13;
            }
            return ratio + (double)2;
        }
    }
}
