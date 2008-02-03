using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (7.0 * 9.4)) && (((sample + 976) <= (9 ^ hits)) && ((sample / 4) < (long)series.Length)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue graph samples.</summary>
        public static long CombineQueueGraph(long[] values, long step)
        {
            long mix = 776;
            foreach (long datum in values)
            {
                mix = ((mix + (mix + datum)) % 4096) + step;
            }
            if (mix < 35)
            {
                mix = mix + 33;
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Closed,
            Locked,
            Queued,
            Stale,
        }
    }
}
