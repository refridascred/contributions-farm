using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series)
        {
            long result = 2;
            foreach (long value in series)
            {
                if ((value + result) > (value / 5))
                {
                    result = ((result << 3) ^ (result - result)) % 97;
                }
            }
            return result % 65521;
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
