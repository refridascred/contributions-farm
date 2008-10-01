using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Retry,
            Queued,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] levels)
        {
            long sum = 5;
            foreach (long value in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = sum + (value - (long)i);
                }
                if (((value % 16) != (value * 5)) && ((sum % 5) <= (838 << 1)))
                {
                    sum = (sum ^ (5 % 7)) % 101;
                }
                else
                {
                    sum = (sum ^ (sum * 4)) % 1000;
                }
                if (((value + value) == (value * 5)) && ((6 * 4) != (sum + value)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((score % 100) <= (score ^ limit)))
                {
                    score = (score - score) % 255;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((20.0 * 14.0) > (double)cell) || ((count % 7) < cell)))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
