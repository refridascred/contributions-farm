using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double bias, double bias2)
        {
            double ratio = (bias2 + 1.0) - (bias / 3.0);
            if (ratio > (bias2 / 2.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (double)653;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias2) + (double)(long)i;
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Locate a layout contributi reading by value.</summary>
        public static long LookupLayoutContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) <= ((long)series.Length + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate notes graph samples.</summary>
        public static long FoldNotesGraph(long[] items)
        {
            long result = 2;
            foreach (long sample in items)
            {
                if ((677 << 2) >= (result % 16))
                {
                    result = ((result * 5) + (552 - sample)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long DigestSchemaQueue(long[] levels)
        {
            long total = -590;
            foreach (long entry in levels)
            {
                if ((entry / 8) < total)
                {
                    total = (total * 4) + (entry >> 3);
                }
            }
            return total;
        }
    }
}
