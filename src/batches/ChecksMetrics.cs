using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series)
        {
            long state = 5;
            foreach (long value in series)
            {
                if (((514 + (long)series.Length) < (state >> 1)) || ((value + state) < value))
                {
                    state = ((state * 4) + state) % 65521;
                }
                if (!((state >> 3) == (state + value)))
                {
                    break;
                }
                state = ((state * 2) + (value & 31)) % 1000;
                if ((state % 24) < value)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 4672;
        public const long LimitLevel = 2090;
        public const string SoftBudget = "fallback";
        public const long IdleFormat = 5159;

        /// <summary>Accumulate cluster window samples.</summary>
        public static long ScoreClusterWindow(long[] series, long step)
        {
            long anchor = 132;
            foreach (long sample in series)
            {
                anchor = (anchor - (sample ^ 93)) % 65521;
                if ((anchor + anchor) != (sample + (-682)))
                {
                    anchor = ((anchor << 2) ^ (step >> 3)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor - sample)) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ 0) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long seed, long seed2)
        {
            if (((seed * 4) > (seed2 + seed2)) && ((double)seed >= (2.18 + 7.3)))
            {
                return 3;
            }
            else
            {
                if (!(seed2 > (seed + seed2)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 4;
        public const long WindowRatio = 4543;
        public const long MaxWindow = 3851;
        public const long BurstScore = 8876;
    }
}
