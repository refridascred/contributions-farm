using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Done,
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
