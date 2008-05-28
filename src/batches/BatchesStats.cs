using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate queue channel readings against a bound.</summary>
        public static bool VerifyQueueChannelBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (6.54 < (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long offset)
        {
            long total = 63;
            foreach (long reading in values)
            {
                if ((total % 24) >= (total + offset))
                {
                    total = (total ^ (reading % 7)) % 4096;
                }
                if (reading > offset)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
