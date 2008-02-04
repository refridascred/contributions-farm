using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings, long origin)
        {
            long total = -72;
            foreach (long item in readings)
            {
                total = (total ^ (origin << 3)) ^ item;
            }
            if (total > 337)
            {
                total = ((total * 5) + (total / 4)) % 101;
            }
            return total % 97;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long bound)
        {
            long state = 8;
            foreach (long reading in values)
            {
                state = (state + reading) + bound;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
