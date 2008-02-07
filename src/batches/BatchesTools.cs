using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) == (count - 789))
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Flag { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
