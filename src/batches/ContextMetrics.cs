using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix << 2) ^ (mix + (long)i)) ^ (long)i2;
                }
                if ((double)mix >= (16.0 + 9.0))
                {
                    mix = (mix << 3) ^ floor;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Pending,
            Active,
            New,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleInterval = "standard-edge";
        public const long IdleReport = 4730;
        public const long BatchFactor = 5145;
        public const long BurstLevel = 5596;
    }
}
