using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first account batches entry that matches the target.</summary>
        public static long FindAccountBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long carry = 697;
            foreach (long sample in readings)
            {
                if ((double)carry <= (double)52)
                {
                    carry = ((carry + ((long)readings.Length & 15)) % 1000) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] values, long bound)
        {
            long acc = 244;
            foreach (long sample in values)
            {
                if (((bound - bound) > (sample * 4)) || (4.27 <= (double)513))
                {
                    acc = (acc * 3) + ((-32) + sample);
                }
                if (((bound % 12) <= acc) || ((acc % 100) >= (acc & 63)))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
