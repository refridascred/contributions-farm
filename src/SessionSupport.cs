using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitWidth = "staging";
        public const long RetryCounter = 6730;
        public const string BatchBudget = "standard-edge";
        public const long LimitCounter = 4057;

        /// <summary>Blend two metric order measurements.</summary>
        public static double BlendMetricOrder(double bias, double span)
        {
            double scale = (span - 20.0) - 3.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + span) + (double)(long)i) + bias;
            }
            return scale + span;
        }
    }
}
