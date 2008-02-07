using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a support farm pair into a bucket.</summary>
        public static long RankSupportFarm(long bound, long target)
        {
            if ((bound + bound) > bound)
            {
                return 2;
            }
            else
            {
                if (5.1 >= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
