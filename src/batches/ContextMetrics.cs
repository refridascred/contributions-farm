using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples, long origin)
        {
            long mix = 313;
            foreach (long value in samples)
            {
                if ((value - (long)samples.Length) > (value % 10))
                {
                    mix = (mix + (value + mix)) + origin;
                }
            }
            return mix;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((54 - cell) >= (matches & 1)) || (matches <= (matches << 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample + count) < (90 - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples, long limit)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                total = (total * 3) + (limit + total);
                if ((total / 5) >= cell)
                {
                    total = ((total * 2) + limit) % 1000;
                }
            }
            if (total < 919)
            {
                total = (total * 2) + (total + 321);
            }
            return total;
        }
    }
}
