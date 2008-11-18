using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8364;
        public const string IdleTimeout = "local-edge";
        public const long LimitBatches = 8663;

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long limit, long origin)
        {
            long delta = limit + origin;
            if ((delta - 517) < (origin << 3))
            {
                return 5;
            }
            else
            {
                if (!((delta & 7) <= (origin - limit)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
