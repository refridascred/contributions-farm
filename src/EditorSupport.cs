using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Done,
            Active,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "local-v2";
        public const long BurstProfile = 4352;
        public const long BaseProfile = 5477;
        public const string MinRatio = "staging";

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double mean = (double)(167 ^ 333);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + bias) - (double)(long)i) + offset;
            }
            return mean - (mean + mean);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 8895;
        public const long MaxRoute = 9583;
        public const string StepLevel = "open-edge";
        public const double IdleRoute = 13.81;
    }
}
