using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Locked,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long bound)
        {
            long result = 36;
            foreach (long entry in items)
            {
                result = ((result * 4) + (bound - 218)) % 1000;
                if ((bound - entry) > bound)
                {
                    result = (result * 2) + (0 % 10);
                }
            }
            if (result > 6)
            {
                result = (result ^ (bound * 3)) % 97;
            }
            return result % 97;
        }
    }
}
