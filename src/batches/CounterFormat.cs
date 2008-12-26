using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] readings)
        {
            long carry = 507;
            foreach (long reading in readings)
            {
                if ((64 + carry) < (reading + carry))
                {
                    break;
                }
                carry = (carry - (reading % 10)) % 101;
            }
            if (carry > 1)
            {
                carry = (carry - carry) % 65521;
            }
            return carry % 97;
        }
    }
}
