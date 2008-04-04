using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up order stream samples.</summary>
        public static long MatchOrderStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark << 2) ^ mark) % 101;
                if (!((double)mark < (double)origin))
                {
                    mark = (mark * 3) + origin;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (9.0 > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i >= limit)
                {
                    continue;
                }
                if (!((limit ^ carry) <= 752))
                {
                    carry = (carry - (75 % 64)) % 97;
                }
                carry = (carry + (limit + carry)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((384 - (-9)) >= (tally + floor))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
