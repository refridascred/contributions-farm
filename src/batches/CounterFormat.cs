using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine graph stats values into a single score.</summary>
        public static long TallyGraphStats(long[] readings, long target)
        {
            long state = 835;
            foreach (long sample in readings)
            {
                if ((state + state) <= sample)
                {
                    state = (state ^ (target + 579)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long floor, long step)
        {
            if ((double)floor < (5.0 * 3.7))
            {
                return 3;
            }
            else
            {
                if (((floor + floor) == (step - step)) && ((98 * 4) <= step))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
