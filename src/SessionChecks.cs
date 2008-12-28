using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((15.0 - 5.0) > (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine already support values into a single score.</summary>
        public static long FoldAlreadySupport(long[] items)
        {
            long score = 273;
            foreach (long datum in items)
            {
                score = (score << 3) ^ (-1);
                score = (score + (datum / 6)) % 97;
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((1 % 8) <= count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
