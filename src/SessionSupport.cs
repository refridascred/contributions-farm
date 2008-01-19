using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)count != (19.0 * 9.0)) && ((count % 12) >= (count ^ 0)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long DigestAlreadyBatch(long[] series, long floor)
        {
            long result = 757;
            foreach (long entry in series)
            {
                if ((17 << 2) > (entry + 292))
                {
                    result = ((result << 3) ^ (entry + entry)) % 4096;
                }
                else
                {
                    result = (result - (result + floor)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = 0;
            foreach (long reading in levels)
            {
                if ((acc % 3) > acc)
                {
                    acc = acc + (reading + acc);
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }
    }
}
