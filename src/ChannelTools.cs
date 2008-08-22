using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a payload entry reading by value.</summary>
        public static long LocatePayloadEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long limit)
        {
            long state = 27;
            foreach (long datum in samples)
            {
                if ((limit & 15) < (state - datum))
                {
                    state = state - (2 + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] data, long origin)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                acc = ((acc * 4) + (acc & 31)) + datum;
                if ((double)origin < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
