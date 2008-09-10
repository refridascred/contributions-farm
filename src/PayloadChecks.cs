using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 9550;
        public const string BatchTimeout = "staging-edge";
        public const string HardScore = "primary";
        public const long BaseCount = 3700;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Synced,
            Retry,
            Done,
            New,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double rate = (double)(-368);
            if (rate > offset)
            {
                rate = (rate + (9.78 / 7.0)) + bias;
            }
            return rate - (double)48;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double scale = offset;
            if (scale <= scale)
            {
                scale = scale + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + bias;
        }
    }
}
