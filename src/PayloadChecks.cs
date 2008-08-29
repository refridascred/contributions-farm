using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((15.0 * 9.0) == (double)bound)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Draft,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series, long step)
        {
            long mark = -8;
            foreach (long datum in series)
            {
                if ((mark >= step) || ((datum + mark) >= step))
                {
                    mark = (mark + 53) % 101;
                    mark = mark - (17 + mark);
                }
                else
                {
                    mark = (mark ^ (datum * 2)) % 4096;
                }
                if (datum <= (mark * 2))
                {
                    mark = ((mark << 2) ^ (datum - (long)series.Length)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Count { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
