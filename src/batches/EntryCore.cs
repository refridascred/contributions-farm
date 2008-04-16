using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 54.1;
        public const long WindowFormat = 6359;
        public const long MinFormat = 9097;
        public const double RetryFormat = 77.53;
        public const long BurstFormat = 9711;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 18.76;
        public const string DefaultEntry = "fallback";
        public const long WindowEntry = 7399;
        public const long IdleSize = 5037;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 7753;
        public const long BaseCount = 2120;
        public const string BaseLevel = "standard-1";
        public const long WindowGraph = 6462;

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((0.7 / 5.0) <= (double)count)
                {
                    count = ((count + 2) + reading) - step;
                }
            }
            return count;
        }
    }
}
