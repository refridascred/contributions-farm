using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Dropped,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Derive the next commits graph value from a seed.</summary>
        public static long SeriesCommitsGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor << 2) ^ (origin + anchor);
                if ((183 ^ (long)i) > origin)
                {
                    anchor = ((anchor * 2) + (origin % 5)) % 65521;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (anchor + (origin * 5)) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleBudget = "primary-1";
        public const long WindowInterval = 3544;
        public const long SoftFactor = 6199;
        public const long HardAlready = 1593;
        public const long SoftBudget = 4727;

        /// <summary>Count the token farm entries that pass the check.</summary>
        public static long CountTokenFarmGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (offset > (count + offset))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
