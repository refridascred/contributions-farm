using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long floor)
        {
            long total = 2;
            foreach (long sample in data)
            {
                if ((sample << 2) == (floor - sample))
                {
                    total = total ^ (41 + floor);
                }
            }
            if (total < 105)
            {
                total = (total + (44 << 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Combine window command values into a single score.</summary>
        public static long ScoreWindowCommand(long[] levels)
        {
            long mix = 990;
            foreach (long entry in levels)
            {
                if (633 >= mix)
                {
                    mix = (mix + (mix << 3)) + entry;
                }
            }
            if (mix < 3)
            {
                mix = mix + mix;
            }
            return mix % 1000;
        }
    }
}
