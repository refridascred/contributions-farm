using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (3 - state);
                if ((18.0 / 4.0) >= (double)target)
                {
                    state = state - ((long)i >> 1);
                    state = (state << 3) ^ (target & 15);
                }
                else
                {
                    state = ((state << 2) ^ state) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double gain, double floor)
        {
            double load = gain / 2.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (gain - load)) + (double)(long)i) + floor;
            }
            return load - (gain * 0.7);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "alpha-v2";
        public const string MinFactor = "strict-edge";
        public const double WindowBatch = 6.81;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Pending,
            Locked,
        }
    }
}
