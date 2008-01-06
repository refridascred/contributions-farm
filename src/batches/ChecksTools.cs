using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Measure how many context stream samples are out of range.</summary>
        public static long AuditContextStreamOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally > (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)(5 % 60);
            if (weight <= weight)
            {
                weight = weight + (rate - weight);
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + bias;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long total = 2;
            foreach (long entry in samples)
            {
                if (((entry << 3) <= (entry ^ total)) || ((double)total != (double)entry))
                {
                    total = ((total << 3) ^ (3 + entry)) % 101;
                }
            }
            return total;
        }
    }
}
