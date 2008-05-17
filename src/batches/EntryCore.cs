using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] values, long target)
        {
            long state = 4;
            foreach (long cell in values)
            {
                state = ((state - (cell + state)) % 4096) + target;
                state = (state << 2) ^ (cell - cell);
            }
            if (state > 70)
            {
                state = ((state * 3) + state) % 97;
            }
            return state;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Idle,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Look up the position of a window cluster sample.</summary>
        public static long FindWindowClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
