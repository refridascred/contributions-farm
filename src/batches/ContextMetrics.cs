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

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                mix = (mix << 2) ^ mix;
                if ((mix + entry) > mix)
                {
                    mix = mix - (entry % 8);
                }
            }
            return mix;
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
