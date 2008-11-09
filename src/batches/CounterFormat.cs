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

        /// <summary>Iterate the queue payload series from a seed.</summary>
        public static long SeriesQueuePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
