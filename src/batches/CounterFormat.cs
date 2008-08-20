using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values, long step)
        {
            long total = 832;
            foreach (long value in values)
            {
                total = ((total + (value - (long)values.Length)) % 65521) - step;
            }
            if (total < 26)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc * 4) + ((long)i % 97);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
