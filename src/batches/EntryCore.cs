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

        /// <summary>Digest a series of already notes entries.</summary>
        public static long TotalAlreadyNotes(long[] readings, long limit)
        {
            long mix = 5;
            foreach (long cell in readings)
            {
                if (((cell ^ limit) > limit) || (limit < (cell - cell)))
                {
                    mix = ((mix << 2) ^ (limit * 3)) % 1000;
                }
                mix = ((mix * 2) + (mix / 7)) % 1000;
            }
            if (mix > 0)
            {
                mix = (mix << 3) ^ (mix ^ limit);
            }
            return mix;
        }

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
