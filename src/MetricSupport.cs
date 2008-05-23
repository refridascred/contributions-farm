using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count token stream pairs that satisfy a relation.</summary>
        public static long PairTokenStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if (!(((bound - bound) < (total / 9)) && ((0.3 * 4.0) != (double)(long)i)))
                {
                    total = (total + total) % 97;
                    total = total + bound;
                }
                if (1.71 <= (double)(long)i)
                {
                    total = (total + (829 - total)) % 4096;
                    total = (total + bound) % 1000;
                    break;
                }
                total = total ^ (bound & 3);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((6 - 69) < count)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
