using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a commits metrics figure with a bias.</summary>
        public static double AdjustCommitsMetrics(double rate, double bias)
        {
            double load = (double)24 + (bias + bias);
            if (load > (rate - rate))
            {
                load = load - (load + rate);
            }
            else
            {
                load = load + (bias * 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 9.35) - (double)(long)i;
            }
            return load - (load + rate);
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Done,
            Dropped,
            Stale,
            Queued,
        }
    }
}
