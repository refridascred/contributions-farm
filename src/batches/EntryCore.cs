using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count * 3) != (entry & 127)) && ((90 + count) <= (entry % 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + tally) < (datum >> 5))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double rate2 = (rate - 1.45) / 4.0;
            if (rate2 >= (rate2 / 5.0))
            {
                rate2 = (rate2 - (0.54 - rate)) - span;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - 0.99) + (double)(long)i;
            }
            return rate2 + 4.0;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((seen ^ seed) >= ((-451) % 60)) && ((376 + seen) == (5 + 884))) || ((datum % 10) < (seen + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
