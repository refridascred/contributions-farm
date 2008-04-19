using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] readings, long step)
        {
            long carry = -607;
            foreach (long sample in readings)
            {
                carry = ((carry + (step / 2)) % 97) - sample;
                if ((96 - step) < (70 >> 5))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double floor)
        {
            double mean = (double)((-28) >> 4);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (double)(long)i) - gain) + floor;
            }
            return mean + (double)0;
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

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data, long limit)
        {
            long acc = 47;
            foreach (long value in data)
            {
                acc = (((acc << 3) ^ (limit << 1)) % 1000) ^ value;
                acc = (acc << 3) ^ (380 & 15);
            }
            if (acc > 894)
            {
                acc = (acc * 5) + (limit * 4);
            }
            return acc;
        }
    }
}
