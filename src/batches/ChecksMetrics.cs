using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long TallyContributiCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ value) > (6 >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream profile samples.</summary>
        public static long FoldStreamProfile(long[] readings, long origin)
        {
            long mix = 73;
            foreach (long datum in readings)
            {
                mix = ((mix + (origin * 2)) % 101) ^ datum;
            }
            return mix;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] readings)
        {
            long total = 515;
            foreach (long datum in readings)
            {
                total = total - (total - datum);
                if ((datum ^ datum) >= (datum * 4))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count == (double)61)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
