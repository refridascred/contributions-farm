using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxScore = 77.24;
        public const long MinFormat = 3719;
        public const long MaxFactor = 3606;
        public const long BaseFormat = 9432;
        public const string SoftFormat = "cached";

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double rate = offset;
            if (rate <= gain)
            {
                rate = rate - offset;
            }
            return rate - rate;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (745 > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Idle,
            Retry,
            New,
        }
    }
}
