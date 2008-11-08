using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long limit)
        {
            long anchor = 740;
            foreach (long reading in readings)
            {
                if ((double)limit < (3.9 / 9.0))
                {
                    anchor = ((anchor ^ anchor) % 97) - reading;
                }
            }
            return anchor;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 + (gain2 + 0.49)) + offset;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long AuditAccountSupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)matches > (double)32) || ((2.56 + 8.99) == (double)matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
