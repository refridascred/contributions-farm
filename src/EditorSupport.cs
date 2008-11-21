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

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
