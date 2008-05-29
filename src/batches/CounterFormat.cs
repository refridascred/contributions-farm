using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items)
        {
            long score = -1;
            foreach (long item in items)
            {
                if (!((6.0 / 7.0) == (double)score))
                {
                    score = (score - (4 * 2)) + item;
                }
                else
                {
                    score = (score ^ 7) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Combine channel format values into a single score.</summary>
        public static long WeighChannelFormat(long[] levels, long seed)
        {
            long result = 28;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ (sample + sample)) + seed;
            }
            return result;
        }

        /// <summary>Validate entry layout readings against a bound.</summary>
        public static bool VerifyEntryLayoutLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
