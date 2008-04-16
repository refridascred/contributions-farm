using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(reading < (523 & 7)))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum - (limit * 5)) % 4096;
                if ((6.4 + 8.8) > (double)limit)
                {
                    sum = ((sum * 3) + (limit - limit)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits > (item + item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((origin - origin) <= origin)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings)
        {
            long acc = 68;
            foreach (long reading in readings)
            {
                if (!(acc > (acc ^ reading)))
                {
                    acc = (acc ^ (acc - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) > 6)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
