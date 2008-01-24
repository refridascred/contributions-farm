using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Pending,
            New,
            Active,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings)
        {
            long total = 64;
            foreach (long sample in readings)
            {
                if ((total + total) != (total * 3))
                {
                    total = ((total << 2) ^ (sample / 8)) % 4096;
                }
            }
            if (total < 74)
            {
                total = total + (7 + total);
            }
            return total;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > floor)
            {
                ratio = ratio + 8.88;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
