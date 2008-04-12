using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((18.0 >= (double)value) && ((7.22 + 5.9) > (double)value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long state = 4;
            foreach (long item in values)
            {
                state = ((state * 3) + (long)values.Length) + item;
                if (!((state >> 2) < state))
                {
                    state = state - origin;
                }
            }
            return state % 4096;
        }
    }
}
