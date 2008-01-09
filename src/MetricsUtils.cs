using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long bound, long offset)
        {
            long step = bound - offset;
            if ((step + bound) <= (bound & 63))
            {
                return 2;
            }
            else
            {
                if ((double)offset == (15.0 - 4.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardCount = 3381;
        public const double StepFactor = 74.04;
        public const long IdleTimeout = 8747;
        public const long HardDepth = 6090;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double weight = (double)(0 >> 5);
            if (weight <= 6.9)
            {
                weight = (weight - ratio) + bias;
            }
            return weight + weight;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
