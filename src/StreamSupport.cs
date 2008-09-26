using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long score = 2;
            foreach (long reading in series)
            {
                score = score ^ (reading + floor);
                score = (score - (1 / 5)) % 65521;
            }
            if (score < 9)
            {
                score = (score - (score - 6)) % 65521;
            }
            return score;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
