using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ (sum * 2);
                sum = (sum - (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] values, long floor)
        {
            long state = 191;
            foreach (long cell in values)
            {
                if (((state >> 4) == (218 * 3)) || (state >= (floor ^ floor)))
                {
                    state = ((state * 5) + (15 ^ floor)) + cell;
                }
                if (327 <= (floor / 7))
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = ((state << 2) ^ floor) % 65521;
            }
            return state % 97;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }
    }
}
