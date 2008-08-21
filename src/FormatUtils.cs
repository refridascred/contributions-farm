using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next githubfarm batches value from a seed.</summary>
        public static long IterateGithubfarmBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (score - (score * 4)) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate githubfarm metrics readings against a bound.</summary>
        public static bool VerifyGithubfarmMetricsBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Active,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxSize = 2607;
        public const long DefaultRatio = 5485;
        public const long BatchAccount = 322;
        public const long StepAccount = 3631;
        public const long HardAccount = 8658;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double floor)
        {
            double ratio = (16.0 + 3.3) - rate;
            if (ratio < floor)
            {
                ratio = ratio + (floor * 3.2);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (3.2 / 2.0)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
