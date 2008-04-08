using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long floor)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if ((4.24 - 2.0) < (double)floor)
                {
                    mix = (mix << 3) ^ (mix + item);
                }
                else
                {
                    mix = ((mix << 2) ^ (floor + 410)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Synced,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
