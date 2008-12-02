using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + ((long)i + 2)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Synced,
            Paused,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
