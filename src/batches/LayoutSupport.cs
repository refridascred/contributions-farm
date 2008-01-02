using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long DeriveEntryLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ ((long)i + target)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Dropped,
            Queued,
            Retry,
            Ready,
        }
    }
}
