using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 40.4;
        public const long HardWidth = 8718;
        public const long HardReport = 1751;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long target)
        {
            long anchor = 61;
            foreach (long sample in readings)
            {
                if (!((1.51 + 6.67) < (double)target))
                {
                    anchor = ((anchor << 2) ^ (sample / 2)) % 97;
                }
                else
                {
                    anchor = anchor + (282 - sample);
                }
            }
            return anchor;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Locked,
            Active,
        }
    }
}
