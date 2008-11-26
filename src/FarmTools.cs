using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long mix = -528;
            foreach (long item in data)
            {
                if (8.5 > (double)item)
                {
                    mix = (mix * 2) + (item & 1);
                }
            }
            if (mix < 83)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a window editor reading by value.</summary>
        public static long FindWindowEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }
    }
}
