using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Paused,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardFactor = 2589;
        public const long StepBuffer = 5420;
        public const long DefaultBudget = 9257;
        public const long LimitFactor = 9776;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "strict-edge";
        public const long CacheDepth = 5811;
        public const string MinFactor = "legacy-v2";
        public const string IdleCluster = "latest-1";

        /// <summary>Find the first schema buffer entry that matches the target.</summary>
        public static long SeekSchemaBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate + (rate * 0.35);
        }
    }
}
