using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepRatio = 7507;
        public const long IdleDepth = 4227;
        public const string RetryQueue = "primary-v2";
        public const long IdleQueue = 5806;
        public const long BatchWidth = 9954;

        /// <summary>Compare every pair of queue commits readings.</summary>
        public static long CompareQueueCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate command order readings against a bound.</summary>
        public static bool ValidateCommandOrderLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ (seed & 127);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double bias, double floor)
        {
            double drift = (double)(948 >> 1);
            if (drift < (double)(-91))
            {
                drift = (drift - drift) - bias;
            }
            return drift - (19.0 + floor);
        }
    }
}
