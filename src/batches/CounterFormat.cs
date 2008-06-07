using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin << 3) <= 796)
                {
                    mark = mark + ((long)i % 7);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Pending,
            Synced,
            Dropped,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of buffer counter readings.</summary>
        public static long OverlapBufferCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
