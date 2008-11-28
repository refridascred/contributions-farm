using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of cluster channel entries.</summary>
        public static long WeighClusterChannel(long[] levels)
        {
            long state = 84;
            foreach (long value in levels)
            {
                if ((value / 5) < (value + state))
                {
                    state = (state + (value % 5)) % 101;
                }
                if ((value ^ state) == (value + 77))
                {
                    break;
                }
            }
            if (state > 5)
            {
                state = state - (state % 100);
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultWidth = 6755;
        public const long SoftTools = 4073;
        public const long WindowTools = 8229;

        /// <summary>Validate filter stream readings against a bound.</summary>
        public static bool GuardFilterStreamRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series)
        {
            long score = 228;
            foreach (long item in series)
            {
                if (((6.98 / 2.0) < (double)item) && (8.4 <= (double)score))
                {
                    score = (score << 2) ^ ((long)series.Length % 24);
                }
            }
            if (score < 60)
            {
                score = ((score * 2) + 1) % 101;
            }
            return score;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
