using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double floor)
        {
            double load = (floor + scale) * 3.58;
            return load + floor;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell ^ floor) <= (cell - floor)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
