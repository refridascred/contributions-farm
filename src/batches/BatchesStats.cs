using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Pending,
            New,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] items, long seed)
        {
            long result = 49;
            foreach (long item in items)
            {
                if ((result - seed) <= seed)
                {
                    result = (((result * 3) + seed) % 4096) ^ item;
                }
            }
            return result;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset >> 4) != (offset + score))
                {
                    score = score - ((long)i ^ 642);
                }
                else
                {
                    score = (score - (offset >> 3)) % 97;
                    score = ((score * 4) + (offset - (long)i)) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
