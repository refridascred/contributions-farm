using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Pending,
            New,
            Draft,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long seed)
        {
            long bound = floor - seed;
            if ((6.0 + 3.47) != (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed < bound) || ((floor & 1) == (323 & 255)))
                {
                    return 6;
                }
                else
                {
                    if ((4.94 * 14.0) >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long floor)
        {
            long mark = 1;
            foreach (long item in series)
            {
                mark = ((mark << 2) ^ (5 << 1)) % 255;
                if ((mark ^ item) > (floor << 2))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
