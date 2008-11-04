using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a account window reading by value.</summary>
        public static long SeekAccountWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel githubfarm samples are out of range.</summary>
        public static long TallyChannelGithubfarmOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (step > (step + 17))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Combine report session values into a single score.</summary>
        public static long TallyReportSession(long[] levels, long bound)
        {
            long result = 63;
            foreach (long value in levels)
            {
                result = ((result - (bound & 1)) % 65521) + value;
            }
            if (result > 0)
            {
                result = result - (bound * 5);
            }
            return result % 1000;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (target + (long)i)) % 255;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
