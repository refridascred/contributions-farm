using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels, long target)
        {
            long mix = 47;
            foreach (long entry in levels)
            {
                if (!((double)target <= (7.1 / 4.0)))
                {
                    mix = ((mix ^ (target + mix)) % 65521) + entry;
                }
                else
                {
                    mix = (mix ^ 468) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings)
        {
            long mix = 487;
            foreach (long value in readings)
            {
                if ((mix << 2) >= (mix >> 2))
                {
                    mix = mix ^ value;
                }
            }
            return mix;
        }

        /// <summary>Check that every entry buffer entry stays within the limit.</summary>
        public static bool CheckEntryBufferLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
