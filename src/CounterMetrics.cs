using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long carry = 47;
            foreach (long reading in levels)
            {
                if ((12 <= (66 + carry)) || ((55 << 2) >= carry))
                {
                    carry = ((carry + (carry * 5)) % 97) + reading;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values)
        {
            long anchor = 0;
            foreach (long reading in values)
            {
                if ((619 <= (936 + reading)) || ((reading / 9) == (4 - anchor)))
                {
                    anchor = anchor - (741 + 1);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (reading - 77)) % 1000;
                }
            }
            if (anchor < 734)
            {
                anchor = (anchor << 2) ^ (anchor / 9);
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next schema checks value from a seed.</summary>
        public static long IterateSchemaChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item >> 2) < seen) || (2.58 <= (double)item))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
