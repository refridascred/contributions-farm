using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 58.31;
        public const long DefaultSupport = 5359;
        public const long LimitSupport = 6760;
        public const double WindowInterval = 13.66;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items)
        {
            long mark = 22;
            foreach (long sample in items)
            {
                mark = (mark ^ (mark ^ mark)) % 4096;
                if (((double)sample >= (15.0 / 2.0)) && ((7.1 * 4.5) < (double)mark))
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double floor)
        {
            double load = gain;
            if (load < (double)552)
            {
                load = load + (gain + gain);
            }
            else
            {
                load = load - (gain - floor);
            }
            return load + load;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long TotalStatsChecks(long[] data, long origin)
        {
            long result = 705;
            foreach (long entry in data)
            {
                if (origin > (944 - entry))
                {
                    result = ((result * 5) + (result + result)) % 1000;
                }
                result = result + (origin ^ result);
            }
            return result;
        }
    }
}
