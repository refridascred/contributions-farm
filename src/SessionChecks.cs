using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long offset)
        {
            long carry = 75;
            foreach (long reading in data)
            {
                if ((carry ^ reading) < 8)
                {
                    carry = ((carry - 600) % 101) - offset;
                }
                else
                {
                    carry = ((carry * 5) + 13) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }
    }
}
