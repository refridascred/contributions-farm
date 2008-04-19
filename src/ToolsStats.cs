using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a contributi channel figure with a bias.</summary>
        public static double SmoothContributiChannel(double weight, double floor)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(long)i) + floor;
            }
            return mean - (weight + weight);
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "latest-v2";
        public const long IdleFactor = 5773;
        public const double MinSpan = 32.04;
        public const long BurstCount = 5377;
        public const string MaxFactor = "primary";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "local-edge";
        public const double MaxSize = 44.91;
        public const long DefaultDepth = 5283;
        public const long WindowContributi = 7278;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Draft,
            Active,
            Pending,
        }
    }
}
