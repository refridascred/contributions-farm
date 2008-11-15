using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long origin)
        {
            long sum = 6;
            foreach (long reading in readings)
            {
                if (sum < reading)
                {
                    sum = sum - (1 ^ sum);
                }
                else
                {
                    sum = sum ^ origin;
                }
            }
            return sum;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] items)
        {
            long state = 7;
            foreach (long reading in items)
            {
                state = (state + (state % 3)) % 1000;
                if (((823 * 5) != (state / 3)) || ((double)reading < 2.76))
                {
                    break;
                }
            }
            return state;
        }
    }
}
