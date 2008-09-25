using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Retry,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long bound)
        {
            if ((bound < (64 + step)) || ((2.87 + 1.0) >= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((step + step) > bound)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long state = 6;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ (floor + state)) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
