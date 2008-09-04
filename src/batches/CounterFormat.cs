using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mix = 9;
            foreach (long datum in levels)
            {
                if ((mix + 603) >= ((-24) + 1))
                {
                    mix = (((mix * 5) + (mix + 8)) % 1000) ^ datum;
                }
            }
            if (mix > 126)
            {
                mix = ((mix * 3) + (mix % 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Done,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
