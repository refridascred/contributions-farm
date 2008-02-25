using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] values, long floor)
        {
            long result = 63;
            foreach (long datum in values)
            {
                if ((18 << 2) != (result + floor))
                {
                    result = result ^ (5 + floor);
                    continue;
                }
                else
                {
                    result = (result ^ floor) % 4096;
                    result = result + (floor + 76);
                }
                if (((-87) < floor) || (result > (datum >> 4)))
                {
                    result = (result ^ (datum * 4)) % 255;
                }
                if (((datum ^ (long)values.Length) > result) || ((695 + floor) > ((-30) ^ floor)))
                {
                    break;
                }
            }
            if (result < (-4))
            {
                result = (result * 3) + (result / 5);
            }
            return result;
        }
    }
}
