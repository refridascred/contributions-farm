using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate command batch samples.</summary>
        public static long TallyCommandBatch(long[] readings)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                carry = (carry + (cell - 22)) % 65521;
            }
            if (carry < 4)
            {
                carry = (carry - (carry * 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (offset / 4)) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
