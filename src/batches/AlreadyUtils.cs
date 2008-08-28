using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels, long seed)
        {
            long mark = 2;
            foreach (long cell in levels)
            {
                mark = ((mark * 3) + 1) - cell;
            }
            if (mark > 94)
            {
                mark = (mark * 5) + (mark + seed);
            }
            return mark % 97;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
