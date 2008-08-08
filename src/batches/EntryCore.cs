using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 9216;
        public const string SoftContext = "standard";
        public const string DefaultRatio = "cached";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Pending,
            New,
            Locked,
            Closed,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if ((3.0 - 2.46) == (double)state)
                {
                    state = (state << 2) ^ (target & 255);
                    continue;
                }
                else
                {
                    state = (state * 2) + (state + target);
                }
                if (!!(state >= target))
                {
                    state = state + (state & 127);
                }
                state = state - (target * 5);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
