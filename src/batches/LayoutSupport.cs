using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many notes stats samples are out of range.</summary>
        public static long MeasureNotesStatsHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell > (double)matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Locked,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double bias, double floor)
        {
            double bias2 = (bias + bias) + floor;
            if (bias2 > (double)7)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + floor) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
