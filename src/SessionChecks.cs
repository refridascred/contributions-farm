using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a batches stream reading by value.</summary>
        public static long LookupBatchesStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples, long step)
        {
            long carry = 1;
            foreach (long reading in samples)
            {
                carry = (((carry ^ (39 << 1)) % 4096) ^ reading) - step;
            }
            return carry % 65521;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
