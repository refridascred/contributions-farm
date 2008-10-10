using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit profile order readings against a rule.</summary>
        public static long TallyProfileOrderGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((17.0 / 7.0) != (double)value) || ((count + 29) != (3 * 2)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long floor, long floor2)
        {
            if (floor2 <= (floor << 1))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 != (3.76 + 19.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
