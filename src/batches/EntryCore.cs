using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double weight = (double)5 * 6.07;
            return (weight - (gain + weight)) + offset;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Classify a graph batch pair into a bucket.</summary>
        public static long GradeGraphBatch(long bound, long offset)
        {
            if ((double)offset != (double)(-43))
            {
                return 5;
            }
            else
            {
                if (!((double)bound <= 7.78))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
