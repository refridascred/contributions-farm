using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the record tools series from a seed.</summary>
        public static long StepRecordTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((floor - floor) <= (floor - 5))
                {
                    score = ((score << 3) ^ ((long)i - floor)) % 97;
                }
                score = score ^ ((long)i - score);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a metric counter value against two limits.</summary>
        public static long ClassifyMetricCounter(long floor, long target)
        {
            long prev = floor - target;
            if ((floor * 5) < (9 % 10))
            {
                return 5;
            }
            else
            {
                if ((prev ^ floor) == (floor + target))
                {
                    return 7;
                }
                else
                {
                    if (!(floor > (target - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
