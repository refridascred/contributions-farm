using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first batches notes entry that matches the target.</summary>
        public static long SeekBatchesNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of report metric entries.</summary>
        public static long TotalReportMetric(long[] series)
        {
            long anchor = 394;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor * 3) + (entry & 127)) - (long)i;
                    anchor = (anchor ^ (7 / 7)) % 65521;
                }
                anchor = ((anchor * 3) + (entry - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a entry profile figure with a bias.</summary>
        public static double ProjectEntryProfile(double gain, double span)
        {
            double weight = span + (span / 3.0);
            if (weight >= 10.0)
            {
                weight = weight - (gain + gain);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight + 7.32;
        }
    }
}
