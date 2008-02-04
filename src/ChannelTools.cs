using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] readings, long origin)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                acc = (acc - (reading % 12)) - origin;
            }
            if (acc < 1)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
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
