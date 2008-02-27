using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the contributi schema entries that pass the check.</summary>
        public static long AuditContributiSchemaHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value << 3) >= target) || ((target / 4) != ((-750) + target)))
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

        /// <summary>Match up farm already samples.</summary>
        public static long CompareFarmAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks format readings against a rule.</summary>
        public static long TallyChecksFormatMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length == (sample * 2)) || ((limit > sample) && ((11.0 * 9.47) <= (double)sample)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a farm metric reading by value.</summary>
        public static long FindFarmMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
