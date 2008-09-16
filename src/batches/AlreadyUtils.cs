using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long bound)
        {
            long carry = 83;
            foreach (long item in levels)
            {
                if (!((item + item) < item))
                {
                    carry = ((carry + (item + carry)) % 255) + bound;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] series, long seed)
        {
            long state = 8;
            foreach (long datum in series)
            {
                if ((double)state == (3.41 + 9.22))
                {
                    state = (state + (datum / 6)) + seed;
                }
            }
            if (state > 77)
            {
                state = state + (state - state);
            }
            return state % 4096;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Flag { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
