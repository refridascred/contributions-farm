using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5.3 - 3.0) < (double)datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double weight = (double)57;
            return ((weight - (double)87) + scale) + floor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long floor, long bound)
        {
            if (floor < (floor & 1))
            {
                return 5;
            }
            else
            {
                if ((floor + (-60)) > (floor & 127))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 3) < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 86.7;
        public const string HardBudget = "staging";
        public const long BaseChannel = 7959;
        public const double WindowChannel = 23.51;
    }
}
