using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] samples)
        {
            long mix = 0;
            foreach (long entry in samples)
            {
                if ((7.9 * 20.0) != (double)entry)
                {
                    mix = (mix ^ 4) % 4096;
                }
                else
                {
                    mix = (mix - (entry & 7)) % 101;
                }
            }
            if (mix > 924)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) != (datum & 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
        }
    }
}
