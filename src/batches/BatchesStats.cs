using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a queue farm sample.</summary>
        public static long LookupQueueFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema order value from a seed.</summary>
        public static long IterateSchemaOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((double)mix < (16.0 / 3.0)) || ((floor ^ mix) >= floor))
                {
                    mix = (mix - (mix + (long)i)) % 4096;
                    mix = (mix * 5) + (floor * 4);
                }
                else
                {
                    mix = (mix << 3) ^ (mix + floor);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum > (datum - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSize = 5762;
        public const long DefaultLevel = 9348;
        public const long BaseRatio = 6187;
        public const long HardContext = 8756;
    }
}
