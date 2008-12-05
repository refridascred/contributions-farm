using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long limit)
        {
            if (limit > (limit - limit))
            {
                return 3;
            }
            else
            {
                if (81 >= (step << 1))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
