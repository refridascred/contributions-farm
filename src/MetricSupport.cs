using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit checks githubfarm readings against a rule.</summary>
        public static long AuditChecksGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - tally) <= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long offset, long floor)
        {
            if ((46 / 4) >= (floor * 5))
            {
                return 0;
            }
            else
            {
                if ((offset + floor) > (offset & 127))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
