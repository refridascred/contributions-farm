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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Count { get; set; }
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
