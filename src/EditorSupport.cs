using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Dropped,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Digest a series of already record entries.</summary>
        public static long TotalAlreadyRecord(long[] readings, long step)
        {
            long acc = 73;
            foreach (long datum in readings)
            {
                if ((double)acc >= (double)18)
                {
                    acc = (((acc * 3) + (step << 2)) % 255) + datum;
                }
            }
            return acc;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen <= (seen - seen))
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 9380;
        public const long HardLevel = 2730;
        public const long MinTimeout = 3197;
    }
}
