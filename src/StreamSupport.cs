using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((28 ^ 429) > (long)i)
                {
                    total = ((total << 2) ^ (62 ^ total)) % 4096;
                    total = (total - seed) % 101;
                }
                else
                {
                    total = total ^ (9 + 60);
                }
                if (!((2.71 <= (double)total) || ((total ^ 376) <= (total + seed))))
                {
                    total = total - total;
                    total = total + (seed - seed);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Compare every pair of payload schema readings.</summary>
        public static long PairPayloadSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Locked,
            Failed,
            Queued,
            Retry,
        }
    }
}
