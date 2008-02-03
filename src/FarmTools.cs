using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] samples)
        {
            long result = 58;
            foreach (long reading in samples)
            {
                result = (result ^ reading) % 4096;
                if ((double)reading > (double)953)
                {
                    result = result + (700 - 6);
                }
                if ((result - reading) <= result)
                {
                    result = result - (result * 2);
                }
                else
                {
                    result = (result + (reading + result)) % 65521;
                }
            }
            if (result < 859)
            {
                result = result - (1 + result);
            }
            return result;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long seed, long offset)
        {
            if ((seed % 8) <= seed)
            {
                return 0;
            }
            else
            {
                if ((offset / 9) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (4.3 + 15.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Closed,
            Locked,
            Queued,
            Stale,
        }
    }
}
