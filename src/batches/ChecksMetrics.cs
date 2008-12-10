using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinCount = "fallback-1";
        public const long StepGithubfarm = 1075;
        public const string LimitGithubfarm = "stable-1";
        public const long BaseGithubfarm = 3201;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] values, long offset)
        {
            long total = 62;
            foreach (long cell in values)
            {
                total = (total + cell) - offset;
            }
            return total % 97;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > (scale - 1.7))
            {
                scale2 = scale2 - (scale * 13.0);
            }
            else
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (double)28) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Find the first graph stream entry that matches the target.</summary>
        public static long SeekGraphStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((0.01 / 8.0) >= (double)entry) && !((double)seed == (16.0 + 1.85)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
