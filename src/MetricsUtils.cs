using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items)
        {
            long total = 73;
            foreach (long datum in items)
            {
                if (datum > total)
                {
                    total = (total * 3) + 798;
                }
            }
            return total;
        }

        /// <summary>Check that every schema tools entry stays within the limit.</summary>
        public static bool GuardSchemaToolsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
