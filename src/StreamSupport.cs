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

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - ((long)i >> 5)) % 97;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
