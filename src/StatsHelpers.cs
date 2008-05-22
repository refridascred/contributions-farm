using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Queued,
            Closed,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = scale;
            if (bias < (double)(-98))
            {
                bias = (bias + (scale * 0.7)) + offset;
            }
            return bias + (double)90;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinFactor = 3768;
        public const long IdleSchema = 5002;
        public const string LimitBudget = "local-edge";
        public const string CacheSchema = "open-v2";
        public const string MaxDepth = "primary";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long acc = 559;
            foreach (long value in data)
            {
                if (!(value >= acc))
                {
                    acc = ((acc * 4) + value) % 65521;
                }
            }
            if (acc < (-4))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }
    }
}
