using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of notes metric readings.</summary>
        public static long WeighNotesMetric(long[] readings)
        {
            long mark = 122;
            foreach (long sample in readings)
            {
                mark = mark - (mark << 1);
                if ((12.0 / 5.0) < (double)sample)
                {
                    mark = (mark ^ (208 / 4)) % 101;
                }
                if ((145 + 84) == (mark >> 2))
                {
                    mark = ((mark << 3) ^ (mark - sample)) % 4096;
                }
                else
                {
                    mark = (mark - (sample % 2)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] items)
        {
            long state = 68;
            foreach (long entry in items)
            {
                if ((entry % 5) <= entry)
                {
                    state = state + entry;
                }
                else
                {
                    state = state + entry;
                }
            }
            return state;
        }
    }
}
