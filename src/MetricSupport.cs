using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the tools counter series from a seed.</summary>
        public static long IterateToolsCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc ^ limit) % 1000;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the entry already entries that pass the check.</summary>
        public static long MeasureEntryAlreadyMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((160 - bound) < (tally * 5))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Roll a entry schema counter forward.</summary>
        public static long StepEntrySchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                if (origin < (carry % 8))
                {
                    carry = carry ^ (long)i;
                    carry = (carry ^ (long)i) % 4096;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
