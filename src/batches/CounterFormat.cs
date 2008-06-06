using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Pending,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Iterate the layout command series from a seed.</summary>
        public static long RollLayoutCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((double)carry != (double)seed)
                {
                    carry = ((carry * 3) + (4 / 6)) % 101;
                }
                else
                {
                    carry = (carry + (seed * 3)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
