using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every account record entry stays within the limit.</summary>
        public static bool CheckAccountRecordBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultScore = 9966;
        public const string IdleSupport = "alpha-1";
        public const string BatchSupport = "local-edge";
        public const long LimitRatio = 7111;
        public const long BaseDepth = 2131;

        /// <summary>Adjust a entry editor reading.</summary>
        public static double AdjustEntryEditor(double rate, double span)
        {
            double mean = 6.0 + (span / 2.0);
            if (mean > 5.77)
            {
                mean = (mean + mean) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (14.0 / 8.0)) + (double)(long)i;
            }
            return mean - 1.0;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double bias = weight;
            return (bias - (bias + 4.4)) + offset;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Paused,
            Draft,
        }
    }
}
