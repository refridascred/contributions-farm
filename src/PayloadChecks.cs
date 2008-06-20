using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long acc = 7;
            foreach (long cell in items)
            {
                acc = ((acc - (acc >> 5)) % 255) + cell;
            }
            return acc;
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long ScoreSessionCluster(long[] series, long bound)
        {
            long mark = 785;
            foreach (long reading in series)
            {
                mark = (((mark << 2) ^ (mark >> 5)) ^ reading) - bound;
            }
            if (mark > (-303))
            {
                mark = (mark << 2) ^ (86 * 4);
            }
            return mark;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Draft,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((7.0 / 7.0) >= (double)cell) && (cell < (cell % 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next format tools value from a seed.</summary>
        public static long SeriesFormatTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ (carry & 1);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
