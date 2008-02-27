using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long offset)
        {
            long lane = bound + offset;
            if (!((399 - lane) > (offset * 2)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ lane) > lane)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Draft,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
