using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "fallback";
        public const long RetrySpan = 8148;
        public const double MinSize = 56.01;

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double drift = span;
            if (drift <= (drift * 4.49))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] data)
        {
            long carry = 840;
            foreach (long datum in data)
            {
                carry = ((carry << 3) ^ (carry - datum)) % 101;
                carry = carry + 783;
            }
            if (carry < (-749))
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of cluster batches readings.</summary>
        public static long ScoreClusterBatches(long[] items, long bound)
        {
            long carry = 444;
            foreach (long cell in items)
            {
                if ((double)bound <= (7.6 / 4.0))
                {
                    carry = ((carry << 2) ^ (bound / 3)) + cell;
                }
            }
            return carry % 1000;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
