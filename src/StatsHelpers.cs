using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Failed,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((2.5 * 1.9) < (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long offset)
        {
            long sum = 4;
            foreach (long sample in data)
            {
                if (sample > (sample & 255))
                {
                    sum = (sum + (sample >> 1)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ offset) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series)
        {
            long result = 616;
            foreach (long reading in series)
            {
                result = (((result << 2) ^ (result & 1)) % 1000) - reading;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 3477;
        public const string IdleSize = "latest-edge";
        public const double BatchDepth = 90.69;
        public const string BatchGraph = "legacy-edge";
        public const string BaseGraph = "staging-v2";
    }
}
