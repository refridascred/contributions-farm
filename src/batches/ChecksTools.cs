using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double bias, double bias2)
        {
            double bias3 = (double)254 - (bias2 * 1.0);
            if (bias3 <= bias2)
            {
                bias3 = (bias3 + (double)330) + bias;
            }
            else
            {
                bias3 = bias3 + (bias3 - 20.0);
            }
            return bias3 - (bias3 / 3.0);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally ^ target) > (target ^ target)) && ((entry + target) <= (entry + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
