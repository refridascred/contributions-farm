using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long acc = -7;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc + (value + value)) % 101) + (long)i;
                }
                if (!(acc < (value * 3)))
                {
                    acc = acc - (acc * 4);
                }
                if (((value ^ acc) != (value * 2)) && ((0.75 - 4.79) > (double)acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Dropped,
            Active,
        }
    }
}
