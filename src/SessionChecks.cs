using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Synced,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Iterate the schema queue series from a seed.</summary>
        public static long StepSchemaQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum - (origin >> 5)) % 97;
                if (!(4.3 >= (double)(long)i))
                {
                    sum = (sum + ((long)i * 5)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items, long bound)
        {
            long state = 70;
            foreach (long value in items)
            {
                state = ((state ^ ((-2) % 12)) % 4096) ^ value;
                state = (state + (bound & 31)) % 65521;
            }
            if (state > 2)
            {
                state = state + state;
            }
            return state;
        }
    }
}
