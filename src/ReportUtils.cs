using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches % 60) < (datum + 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long CountFormatBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)sample <= (4.82 - 3.7)) && ((14.0 + 2.6) > (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
