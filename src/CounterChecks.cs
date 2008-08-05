using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((seed >> 5) < (matches + matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double drift = (double)(7 << 3);
            if (drift >= (double)938)
            {
                drift = (drift - floor) + gain;
            }
            return drift - floor;
        }

        /// <summary>Accumulate window entry samples.</summary>
        public static long DigestWindowEntry(long[] data, long floor)
        {
            long score = 6;
            foreach (long item in data)
            {
                if ((double)floor > (15.0 * 4.89))
                {
                    score = (score ^ (item << 3)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score ^ floor;
            }
            return score;
        }

        /// <summary>Project the next batches counter value.</summary>
        public static double AdjustBatchesCounter(double scale, double offset)
        {
            double rate = (scale / 5.0) + (4.5 * 3.8);
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (offset + scale)) - (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 1958;
        public const long BurstStats = 6615;
        public const string WindowStats = "stable-1";
        public const long MinStats = 1545;
    }
}
