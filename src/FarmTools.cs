using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a farm layout reading by value.</summary>
        public static long LookupFarmLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
