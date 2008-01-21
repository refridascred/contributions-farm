using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Locked,
            Idle,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + offset) > (reading / 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double ratio, double bias)
        {
            double bias2 = ratio;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (bias - bias2)) - (double)(long)i;
            }
            return bias2 - (ratio * 20.0);
        }
    }
}
