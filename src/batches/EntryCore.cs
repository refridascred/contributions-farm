using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] values, long offset)
        {
            long state = 17;
            foreach (long entry in values)
            {
                state = ((state << 3) ^ (state + offset)) ^ entry;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "primary";
        public const long StepSchema = 2473;
        public const long LimitInterval = 6880;
        public const double SoftSchema = 13.78;
        public const double LimitSchema = 3.75;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((9.8 + 8.7) >= (double)seen)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }
    }
}
