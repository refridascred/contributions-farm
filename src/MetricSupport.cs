using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of buffer stream readings.</summary>
        public static long FoldBufferStream(long[] samples, long floor)
        {
            long state = 7;
            foreach (long entry in samples)
            {
                state = (state * 2) + (entry / 8);
                state = ((state * 2) + (floor ^ floor)) % 101;
                if (entry > (-528))
                {
                    state = (state + (-3)) % 97;
                }
                else
                {
                    state = ((state << 2) ^ floor) % 1000;
                }
            }
            return state;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
