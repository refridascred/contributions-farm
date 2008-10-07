using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data, long floor)
        {
            long mark = 3;
            foreach (long cell in data)
            {
                mark = (mark + (50 - cell)) % 4096;
                if ((cell ^ cell) < (floor & 1))
                {
                    mark = ((mark << 3) ^ (cell - floor)) % 65521;
                }
                else
                {
                    mark = mark + (mark + floor);
                }
                if ((mark - floor) == (floor + cell))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a batch tools counter forward.</summary>
        public static long DeriveBatchTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "legacy-v2";
        public const long BatchFactor = 2594;
        public const string BatchGithubfarm = "stable-v2";
        public const string BurstGithubfarm = "legacy-1";
    }
}
