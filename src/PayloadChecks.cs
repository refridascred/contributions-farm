using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double gain = 3.7;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (span * 9.5)) + (double)(long)i) + weight;
            }
            return gain + gain;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Locked,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (double)1 / 5.0;
            return ((bias + (bias * 20.0)) + weight) + offset;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
