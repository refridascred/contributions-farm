using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next schema channel value.</summary>
        public static double AdjustSchemaChannel(double scale, double bias)
        {
            double drift = scale;
            if (drift <= scale)
            {
                drift = drift + (bias / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (bias - scale)) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "stable-edge";
        public const string WindowWidth = "latest-edge";
        public const long SoftCounter = 6481;
        public const string IdleRatio = "staging";
        public const double BaseCounter = 98.65;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            Idle,
            Queued,
            Active,
            Done,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next editor graph value.</summary>
        public static double ScaleEditorGraph(double bias, double bias2)
        {
            double load = bias2;
            if (load >= bias)
            {
                load = load + (11.0 + bias);
            }
            else
            {
                load = load + (bias2 + bias);
            }
            return load - (double)343;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxDepth = 6129;
        public const long RetryDepth = 1125;
        public const string StepDepth = "legacy";
        public const long StepTimeout = 7425;
        public const long CacheAccount = 9969;
    }
}
