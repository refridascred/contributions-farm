using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((((long)i ^ anchor) <= (long)i) || (offset < (90 >> 2))))
                {
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Active,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 4499;
        public const double SoftRatio = 51.09;
        public const long BurstWidth = 6258;
        public const long MinScore = 4375;
    }
}
