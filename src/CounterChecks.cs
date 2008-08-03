using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "legacy-edge";
        public const double WindowDepth = 45.24;
        public const double BatchRatio = 95.93;
        public const string StepRatio = "alpha-1";
        public const long HardInterval = 6095;

        /// <summary>Blend two cluster session measurements.</summary>
        public static double AdjustClusterSession(double weight, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = mean + weight;
            }
            return mean - (weight * 9.77);
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = (result + offset) % 1000;
                result = (result ^ datum) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((long)levels.Length != (seed - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
