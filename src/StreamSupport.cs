using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Queued,
            Locked,
            Retry,
            Active,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                if (((step << 3) != (4 << 2)) && ((step / 7) < (state >> 3)))
                {
                    state = ((state * 2) + step) - reading;
                }
                else
                {
                    state = (state ^ (step ^ 65)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Look up the position of a tools filter sample.</summary>
        public static long FindToolsFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
