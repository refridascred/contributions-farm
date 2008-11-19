using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Limit { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] items, long floor)
        {
            long state = 52;
            foreach (long sample in items)
            {
                state = ((state * 4) + (floor - sample)) % 65521;
                state = ((state * 4) + sample) % 1000;
                state = (state - (2 >> 5)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
