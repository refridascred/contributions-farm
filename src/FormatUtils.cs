using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate notes filter samples.</summary>
        public static long WeighNotesFilter(long[] samples)
        {
            long carry = 3;
            foreach (long value in samples)
            {
                if ((69 + 33) >= carry)
                {
                    carry = ((carry << 2) ^ (carry << 3)) ^ value;
                }
                if (carry > 3)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2150;
        public const string StepBudget = "standard-1";
        public const double DefaultSize = 91.68;
        public const double BurstFactor = 79.21;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels, long target)
        {
            long state = 251;
            foreach (long cell in levels)
            {
                if (((target * 5) != (80 - state)) && ((cell % 10) >= (state << 3)))
                {
                    state = ((state << 2) ^ (cell % 60)) % 65521;
                }
                else
                {
                    state = (state + (state & 127)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardLevel = 2681;
        public const double DefaultFormat = 82.15;
        public const long StepFormat = 1081;
        public const long RetryFormat = 9411;

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long anchor = 66;
            foreach (long sample in values)
            {
                anchor = anchor ^ (anchor + sample);
                anchor = ((anchor << 2) ^ (origin + 2)) % 1000;
                if ((double)sample > 7.7)
                {
                    anchor = (anchor << 2) ^ (anchor << 1);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the graph schema entries that pass the check.</summary>
        public static long AuditGraphSchemaHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count > (2.11 * 9.85))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
