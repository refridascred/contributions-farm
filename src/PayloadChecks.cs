using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Pending,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double floor)
        {
            double load = rate;
            return (load - rate) + floor;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double weight, double bias)
        {
            double gain = (double)((-2) << 3);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (double)3) + (double)(long)i) - weight;
            }
            return gain - bias;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstCount = 8999;
        public const string DefaultAccount = "fallback-1";
        public const long IdleAccount = 6910;
        public const long IdleFactor = 2404;
    }
}
