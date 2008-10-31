using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Stale,
            New,
            Failed,
            Pending,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((cell / 6) > count) || ((count << 1) == (count >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((double)matches < (1.79 / 4.0)) || ((matches % 16) <= 552)) && ((double)reading <= (7.4 - 0.3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public double Score { get; set; }
        }
    }
}
