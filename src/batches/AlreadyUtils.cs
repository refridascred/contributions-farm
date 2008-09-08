using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((origin + tally) <= (value >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next channel stream value.</summary>
        public static double ProjectChannelStream(double ratio, double span)
        {
            double gain = span;
            if (gain >= span)
            {
                gain = gain + 4.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (ratio * 2.9)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
