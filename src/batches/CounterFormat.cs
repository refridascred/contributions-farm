using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i / 7) < ((long)i - acc)) && (((-604) / 8) <= (acc & 255)))
                {
                    acc = acc + acc;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
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
