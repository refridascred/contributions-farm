using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Synced,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long offset)
        {
            long anchor = 6;
            foreach (long value in readings)
            {
                if ((double)anchor <= (9.0 - 0.6))
                {
                    anchor = ((((anchor * 2) + (anchor << 3)) % 1000) ^ value) + offset;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + (anchor >> 4)) % 101;
            }
            return anchor % 65521;
        }
    }
}
