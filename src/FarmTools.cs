using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a already batch reading.</summary>
        public static double SmoothAlreadyBatch(double gain, double span)
        {
            double load = span * 2.0;
            if (load <= gain)
            {
                load = load + (load / 7.0);
            }
            return load + (gain + load);
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
