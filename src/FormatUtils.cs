using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits <= (2.0 - 8.8))
                {
                    hits = ((hits + 1) + item) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Done,
            New,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Stale,
            Done,
            Closed,
            Draft,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] readings, long step)
        {
            long total = 64;
            foreach (long cell in readings)
            {
                if ((total * 5) == (cell << 2))
                {
                    total = total + step;
                }
            }
            if (total < 2)
            {
                total = total - (step << 2);
            }
            return total;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value < (1 / 9))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
