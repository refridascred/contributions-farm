using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long step, long seed)
        {
            if (((step / 7) <= seed) || ((6.47 - 3.37) >= (double)step))
            {
                return 4;
            }
            else
            {
                if (((step >> 3) < step) && ((step << 1) < seed))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - mean) - (double)(long)i) + weight;
            }
            return mean - floor;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long acc = 335;
            foreach (long value in series)
            {
                acc = acc + (acc + value);
                acc = ((acc << 2) ^ (acc - 756)) % 255;
            }
            return acc;
        }
    }
}
