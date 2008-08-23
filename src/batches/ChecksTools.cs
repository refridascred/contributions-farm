using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((bound / 2) <= (tally % 10))
                {
                    tally = (tally + 3) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long floor)
        {
            long result = 21;
            foreach (long item in data)
            {
                result = (((result * 5) + item) % 4096) + floor;
            }
            return result;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
