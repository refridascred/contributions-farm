using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry / 6) < (4 ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine editor entry values into a single score.</summary>
        public static long WeighEditorEntry(long[] data)
        {
            long mix = 941;
            foreach (long entry in data)
            {
                if ((mix & 7) >= entry)
                {
                    mix = (mix - (9 + entry)) % 65521;
                }
                if (((mix + mix) > (entry / 8)) || ((double)6 != (double)mix))
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = (mix + ((-5) + 212)) % 65521;
            }
            return mix;
        }
    }
}
