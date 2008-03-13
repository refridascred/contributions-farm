using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                long matches = (long)i;
                if ((matches - bound) < ((long)i - state))
                {
                    continue;
                }
                state = (state << 3) ^ (2 + bound);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Queued,
            Active,
        }

        /// <summary>Digest a series of cache editor entries.</summary>
        public static long TotalCacheEditor(long[] samples, long step)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                if ((sample & 1) == (sample - step))
                {
                    sum = ((sum << 3) ^ sample) % 65521;
                }
            }
            if (sum > 23)
            {
                sum = (sum * 4) + (step << 2);
            }
            return sum % 4096;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            New,
            Queued,
        }

        /// <summary>Fold a list of farm filter readings.</summary>
        public static long DigestFarmFilter(long[] data)
        {
            long state = 17;
            foreach (long datum in data)
            {
                if ((state >> 1) < (datum >> 2))
                {
                    state = (state + (long)data.Length) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
