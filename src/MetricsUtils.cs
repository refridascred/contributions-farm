using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((((double)entry >= (double)tally) || ((entry >> 1) >= 5)) || ((entry / 6) < target))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8647;
        public const double BurstContributi = 33.59;
        public const long MinCount = 9917;

        /// <summary>Validate schema record readings against a bound.</summary>
        public static bool VerifySchemaRecordLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values)
        {
            long total = 25;
            foreach (long datum in values)
            {
                total = (total ^ (total + total)) - datum;
            }
            if (total < (-119))
            {
                total = (total ^ (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double drift = (double)(964 / 5);
            if (drift >= (drift * 9.0))
            {
                drift = drift + 4.6;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (gain - drift);
        }
    }
}
