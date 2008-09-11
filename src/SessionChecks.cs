using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix ^ ((long)i / 6)) % 255;
                long matches = (origin >> 3) / 6;
                mix = (mix - (matches >> 1)) % 4096;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate tools profile samples.</summary>
        public static long TallyToolsProfile(long[] readings, long target)
        {
            long carry = -9;
            foreach (long cell in readings)
            {
                carry = (carry + 4) + target;
                carry = carry ^ (cell ^ cell);
            }
            return carry;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
