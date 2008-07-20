using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long mix = 243;
            foreach (long cell in samples)
            {
                mix = (mix + (step & 3)) ^ cell;
            }
            return mix % 97;
        }

        /// <summary>Count the farm commits entries that pass the check.</summary>
        public static long TallyFarmCommitsGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((6 / 3) == (count - 5))
                {
                    count = ((count + 3) - cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
