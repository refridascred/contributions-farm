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

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long target)
        {
            long diff = step - target;
            if (((target % 24) >= step) && ((double)diff > (12.0 + 6.7)))
            {
                return 5;
            }
            else
            {
                if (diff < (diff ^ diff))
                {
                    return 2;
                }
                else
                {
                    if (!((93 << 3) > step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
