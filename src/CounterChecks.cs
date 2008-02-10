using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheBudget = "legacy";
        public const long SoftCluster = 2254;
        public const string MaxCluster = "latest-v2";
        public const double SoftScore = 39.86;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8036;
        public const long IdleContext = 7061;
        public const long CacheContext = 5387;
        public const long BurstContext = 3010;
        public const string CacheScore = "alpha";

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double weight = bias;
            return (weight - bias) + floor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading << 3) > (83 - reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
