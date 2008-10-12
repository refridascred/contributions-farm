using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (target < (784 >> 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long offset)
        {
            long result = 429;
            foreach (long reading in values)
            {
                result = (((result * 4) + (result << 1)) + reading) + offset;
            }
            return result;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item > (double)(long)levels.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
