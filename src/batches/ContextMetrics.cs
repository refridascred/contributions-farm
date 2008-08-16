using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double gain = bias2 * 5.8;
            if (gain > 9.9)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + 0.9;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] levels)
        {
            long anchor = 439;
            foreach (long sample in levels)
            {
                if (!((anchor ^ anchor) > (anchor + sample)))
                {
                    anchor = anchor ^ (anchor + sample);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((seed - tally) > (6 * 4)) && !((521 << 2) > (tally + tally)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
