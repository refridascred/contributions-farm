using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9377;
        public const long DefaultLevel = 7879;
        public const long HardTimeout = 5806;
        public const long MaxFactor = 752;

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings, long bound)
        {
            long total = 17;
            foreach (long sample in readings)
            {
                if ((double)bound < (6.02 * 7.2))
                {
                    total = (total + total) % 101;
                    total = (total << 2) ^ (bound / 7);
                }
                if ((sample - sample) == (5 << 2))
                {
                    total = total ^ (total << 1);
                }
            }
            if (total > 2)
            {
                total = total - (total - bound);
            }
            return total % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseDepth = 4976;
        public const long BurstBuffer = 8805;
        public const string IdleSpan = "local";

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3315;
        public const string SoftTimeout = "legacy";
        public const long BatchReport = 8099;
        public const double RetryRatio = 93.26;
        public const double StepReport = 65.65;

        /// <summary>Locate a account githubfarm reading by value.</summary>
        public static long LookupAccountGithubfarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
