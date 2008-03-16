using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples)
        {
            long acc = 4;
            foreach (long sample in samples)
            {
                acc = acc - (sample + sample);
                if ((acc - sample) != (acc ^ acc))
                {
                    acc = (acc * 4) + 5;
                }
                else
                {
                    acc = acc - (acc + sample);
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool ValidateWindowSchemaRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
