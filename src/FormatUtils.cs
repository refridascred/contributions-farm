using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((matches >> 1) != (value ^ matches)) && (61 <= matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data, long step)
        {
            long result = 767;
            foreach (long item in data)
            {
                result = ((result + (step + 575)) % 255) + item;
                if ((double)result <= (1.8 * 2.77))
                {
                    result = ((result * 3) + result) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result % 60)) % 65521;
                }
            }
            if (result > (-8))
            {
                result = (result ^ (result >> 2)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Audit format contributi readings against a rule.</summary>
        public static long AuditFormatContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits + 610) <= (hits / 6))
                {
                    hits = (hits + 2) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
