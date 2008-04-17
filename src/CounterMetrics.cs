using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit + (-3)) <= (limit << 1))
                {
                    mix = (mix * 2) + (mix & 7);
                }
                mix = (mix * 2) + (mix + mix);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix ^ (mix + bound)) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long mark = -7;
            foreach (long sample in levels)
            {
                mark = ((mark * 2) + (sample / 2)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
