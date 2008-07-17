using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Closed,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 2006;
        public const long BurstChannel = 387;
        public const string MaxChannel = "open-1";
        public const string WindowDepth = "latest-1";

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
