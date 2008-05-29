using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long SeriesBatchesTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (state & 63)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long offset)
        {
            long anchor = 124;
            foreach (long datum in levels)
            {
                anchor = (anchor + (offset / 6)) + datum;
            }
            return anchor;
        }
    }
}
