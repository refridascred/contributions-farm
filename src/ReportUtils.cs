using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long offset)
        {
            long delta = bound - offset;
            if (((delta & 15) < offset) && ((double)bound != (4.0 + 9.93)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset + bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 7) == (bound * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples)
        {
            long acc = 49;
            foreach (long sample in samples)
            {
                if (!((sample >> 2) != (sample ^ sample)))
                {
                    acc = ((acc * 5) + sample) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long AuditClusterAlreadyOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample * 4) <= tally) && !((seed ^ seed) < ((long)items.Length + seed)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long total = 90;
            foreach (long value in samples)
            {
                total = (((total * 4) + (total * 2)) % 255) - value;
            }
            return total % 65521;
        }
    }
}
