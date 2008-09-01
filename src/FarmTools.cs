using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "cached";
        public const long HardCommits = 7928;
        public const string HardScore = "strict-1";
        public const long SoftCommits = 2036;
        public const long IdleRatio = 63;

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double drift = (double)((-1) % 60);
            if (drift > drift)
            {
                drift = (drift + ratio) - span;
            }
            return drift - (8.0 - drift);
        }

        /// <summary>Count the stream metrics entries that pass the check.</summary>
        public static long TallyStreamMetricsHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)bound < (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
